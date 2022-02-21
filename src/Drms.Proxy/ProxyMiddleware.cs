using DRMS.HttpClient;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using System.Text;

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

            if (HttpMethods.IsPost(request.Method))
            {
                int requestLen = (int)request.ContentLength;
                byte[] buffer = new byte[requestLen];
                int numButesRead = 0;
                context.Request.Body.Position = 0;
                while (numButesRead < requestLen)
                {
                    int readBytes = await request.Body.ReadAsync(buffer, numButesRead, requestLen - numButesRead);
                    numButesRead += readBytes;
                }
                context.Request.Body.Position = 0;

                logger.LogInformation(Encoding.UTF8.GetString(buffer));
            }

            var newCase = request.Headers.TryGetValue("Content-Type", out StringValues action)
                && action.ToString() == "application/soap+xml;charset=UTF-8;action=\"http://schemas.deloitte.com/oim/drms/2013/01/25/service/CaseManagementService/OriginateCase\"";

            logger.LogInformation("Action header is {action}", action);

            var httpClient = context.RequestServices
            .GetService<IHttpClientFactory>()
            .CreateClient("drmsclient");

            var proxiedRequest = await context.CreateProxiedHttpRequest($"{options.ProxyHost}{request.Path}");
            var response = await context.SendProxiedHttpRequestAsync(proxiedRequest, httpClient);

            //var proxyResponse = await response.Content.ReadAsStringAsync();
            //logger.LogInformation("Proxy response {proxyResponse}", proxyResponse);

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

            ////var result = await crmApi.CreateDrmsCase(new CreateCaseRequest("test1", 1384535));
            //await crmntegration.CreateDrmsCase(request, response);

            //await context.WriteProxiedHttpResponseAsync(response);
            //if (HttpMethods.IsPost(request.Method))
            //{
            //    int requestLen = (int)request.ContentLength;
            //    byte[] buffer = new byte[requestLen];
            //    int numButesRead = 0;
            //    context.Request.Body.Position = 0;
            //    while (numButesRead < requestLen)
            //    {
            //        int readBytes = await request.Body.ReadAsync(buffer, numButesRead, requestLen - numButesRead);
            //        numButesRead += readBytes;
            //    }
            //    context.Request.Body.Position = 0;

            //    using (Stream stream = new MemoryStream(buffer))
            //    {
            //        XElement xml = await XElement.LoadAsync(stream, LoadOptions.None, CancellationToken.None);
            //        var body = FindDescendants(xml, "Body").FirstOrDefault();
            //        var name = (body.FirstNode as XElement).Name.LocalName;
            //    }

            //}


            //await next(context);
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
