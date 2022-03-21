using DRMS.HttpClient;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using System.Net;
using System.Text;

namespace Drms.Proxy
{
    public class ProxyMiddleware
    {

        private readonly RequestDelegate next;
        private readonly ILogger<ProxyMiddleware> logger;
        private readonly ICRMIntegration crmntegration;
        private readonly ProxyMiddlewareOptions options;
        private readonly CommonOptions commonOptions;

        public ProxyMiddleware(
            RequestDelegate next,
            ILogger<ProxyMiddleware> logger,
            ICRMIntegration crmntegration,
            IOptions<ProxyMiddlewareOptions> options,
            IOptions<CommonOptions> commonOptions)
        {
            this.next = next;
            this.logger = logger;
            this.crmntegration = crmntegration;
            this.options = options?.Value ?? throw new ArgumentNullException(nameof(options));
            this.commonOptions = commonOptions?.Value ?? throw new ArgumentNullException(nameof(commonOptions));
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.Request;

            var newCase = request.Headers.TryGetValue("Content-Type", out StringValues action)
                && action.ToString() == "application/soap+xml;charset=UTF-8;action=\"http://schemas.deloitte.com/oim/drms/2013/01/25/service/CaseManagementService/OriginateCase\"";

            logger.LogTrace("Action header is {action}", action);

            var response = new HttpResponseMessage(HttpStatusCode.OK);

            if (commonOptions.EnableProxy)
            {
                var httpClient = context.RequestServices
                .GetService<IHttpClientFactory>()?
                .CreateClient("drmsclient") ?? throw new InvalidOperationException("drmsclient is null");

                var proxiedRequest = await context.CreateProxiedHttpRequest($"{options.ProxyHost}{request.Path}");
                response = await context.SendProxiedHttpRequestAsync(proxiedRequest, httpClient);
            }

            if (newCase)
            {
                logger.LogInformation("New case start creating in Integra");

                try
                {
                    if (HttpMethods.IsPost(request.Method))
                    {
                        int requestLen = (int)request.ContentLength;
                        byte[] buffer = new byte[requestLen];
                        int numButesRead = 0;
                        request.Body.Position = 0;
                        while (numButesRead < requestLen)
                        {
                            int readBytes = await request.Body.ReadAsync(buffer, numButesRead, requestLen - numButesRead);
                            numButesRead += readBytes;
                        }
                        request.Body.Position = 0;

                        var drmsResponse = new byte[0];

                        if (commonOptions.EnableProxy)
                        {
                            drmsResponse = await response.Content.ReadAsByteArrayAsync();
                            logger.LogInformation(Encoding.UTF8.GetString(drmsResponse));
                        }

                        if (await crmntegration.CreateDrmsCase(buffer, drmsResponse))
                        {
                            logger.LogInformation("New case created in Integra");
                        }
                        else
                        {
                            logger.LogError("New case creating failed in Integra");
                        }
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
