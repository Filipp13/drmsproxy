namespace Drms.Proxy
{
    public interface ICRMIntegration
    {
        Task<bool> CreateDrmsCase(HttpRequest httpRequest, HttpResponseMessage httpResponse);
    }
}
