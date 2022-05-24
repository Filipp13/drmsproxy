using System.Net;

namespace CRM.HttpClient
{
    internal class CRMHttpClientHandler : HttpClientHandler
    {
        public CRMHttpClientHandler()
        {
            var login = Environment.GetEnvironmentVariable("CRMLogin") ?? throw new NullReferenceException("CRMLogin is absent");
            var password = Environment.GetEnvironmentVariable("CRMPassword") ?? throw new NullReferenceException("CRMPassword is absent");

            Credentials = new NetworkCredential(login, password, "ruby");
        }
    }
}