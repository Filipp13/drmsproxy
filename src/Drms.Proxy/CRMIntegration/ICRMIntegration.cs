namespace Drms.Proxy
{
    public interface ICRMIntegration
    {
        Task<bool> CreateDrmsCase(byte[] request, byte[] drmsResponse);
    }
}
