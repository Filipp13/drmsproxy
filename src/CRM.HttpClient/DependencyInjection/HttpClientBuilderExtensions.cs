using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using Polly.Extensions.Http;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace CRM.HttpClient
{

    public static class HttpClientBuilderExtensions
    {
        public static IHttpClientBuilder AddCRMHttpClient(
          this IServiceCollection services,
          IConfiguration configuration)
        {
            var options = configuration
                      .GetSection(CRMServiceOptions.SectionName)
                      .Get<CRMServiceOptions>();

            if (options is null)
            {
                throw new InvalidOperationException(
                    $"Configuration options {CRMServiceOptions.SectionName} is absent");
            }

            services.Configure<CRMServiceOptions>(configuration.GetSection(CRMServiceOptions.SectionName));
            services.AddTransient<CRMHttpClientHandler>();

            return services
              .AddHttpClient<ICRMApi, CRMApi>()
              .SetHandlerLifetime(TimeSpan.FromMinutes(2))
              .AddPolicyHandler(GetRetryPolicy(options.RetryCount, options.RetryDelay))
              .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(options.TryTimeout))
              .ConfigureHttpClient(client =>
              {
                  client.BaseAddress = new Uri(options.BaseAddress!);
                  client.Timeout = TimeSpan.FromSeconds(options.OverallTimeout);
                  client.DefaultRequestHeaders.Add("OData-MaxVersion", "4.0");
                  client.DefaultRequestHeaders.Add("OData-Version", "4.0");
                  client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
              })
              .ConfigurePrimaryHttpMessageHandler<CRMHttpClientHandler>();
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