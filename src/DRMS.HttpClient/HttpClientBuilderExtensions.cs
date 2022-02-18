using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace DRMS.HttpClient
{

    public static class HttpClientBuilderExtensions
    {
        public static IHttpClientBuilder AddDRMSHttpClient(
          this IServiceCollection services,
          IConfiguration configuration)
        {
            var options = configuration
                      .GetSection(ProxyMiddlewareOptions.SectionName)
                      .Get<ProxyMiddlewareOptions>();

            if (options is null)
            {
                throw new InvalidOperationException($"Configuration options {ProxyMiddlewareOptions.SectionName} is absent");
            }

            services.Configure<ProxyMiddlewareOptions>(configuration.GetSection(ProxyMiddlewareOptions.SectionName));
            
            services.AddTransient<DRMSHttpClientHandler>();

            return services
             .AddHttpClient("drmsclient")
             .SetHandlerLifetime(TimeSpan.FromMinutes(3))
             .AddPolicyHandler(GetRetryPolicy(options.RetryCount, options.RetryDelay))
             .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(options.TryTimeout))
             .ConfigureHttpClient(client =>
             {
                 client.BaseAddress = new Uri(options.ProxyHost);
                 client.Timeout = TimeSpan.FromSeconds(options.OverallTimeout);
             })
             .ConfigurePrimaryHttpMessageHandler<DRMSHttpClientHandler>();

        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy(int retryCount, int retryDelay)
        {
            return HttpPolicyExtensions
              .HandleTransientHttpError()
              .WaitAndRetryAsync(retryCount,
                retryAttempt => TimeSpan.FromSeconds(Math.Pow(retryDelay, retryAttempt)));
        }
    }
}