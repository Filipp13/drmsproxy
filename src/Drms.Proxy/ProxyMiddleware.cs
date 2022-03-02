using DRMS.HttpClient;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;

namespace Drms.Proxy
{
    public class ProxyMiddleware
    {

        private readonly RequestDelegate next;
        private readonly ILogger<ProxyMiddleware> logger;
        private readonly ICRMIntegration crmntegration;
        private readonly ProxyMiddlewareOptions options;

        public ProxyMiddleware(
            RequestDelegate next,
            ILogger<ProxyMiddleware> logger,
            ICRMIntegration crmntegration,
            IOptions<ProxyMiddlewareOptions> options)
        {
            this.next = next;
            this.logger = logger;
            this.crmntegration = crmntegration;
            this.options = options?.Value ?? throw new ArgumentNullException(nameof(options));
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.Request;

            var newCase = request.Headers.TryGetValue("Content-Type", out StringValues action)
                && action.ToString() == "application/soap+xml;charset=UTF-8;action=\"http://schemas.deloitte.com/oim/drms/2013/01/25/service/CaseManagementService/OriginateCase\"";

            logger.LogTrace("Action header is {action}", action);

            var httpClient = context.RequestServices
            .GetService<IHttpClientFactory>()?
            .CreateClient("drmsclient") ?? throw new InvalidOperationException("drmsclient is null");

            var proxiedRequest = await context.CreateProxiedHttpRequest($"{options.ProxyHost}{request.Path}");
            var response = await context.SendProxiedHttpRequestAsync(proxiedRequest, httpClient);

            if (newCase)
            {
                logger.LogInformation("New case start creating in Integra");

                try
                {
                    if (await crmntegration.CreateDrmsCase(request, response))
                    {
                        logger.LogInformation("New case created in Integra");
                    }
                    else
                    {
                        logger.LogError("New case creating failed in Integra");
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Unhandled error while creating case in integra");
                }
            }

            await context.WriteProxiedHttpResponseAsync(response);
        }


    }

    public static class ProxyMiddlewareExtensions
    {
        public static IApplicationBuilder UseProxyMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ProxyMiddleware>();
        }
    }

}
