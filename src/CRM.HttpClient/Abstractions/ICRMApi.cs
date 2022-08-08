using System.Threading.Tasks;

namespace CRM.HttpClient
{
    public interface ICRMApi
    {
        Task<bool> CreateDrmsCase(NewCaseRequest createCaseRequest);

        Task<ModelForRequest> GetLookups(
            string opportunityName,
            string caserequestor,
            string productName,
            string accountId,
            string countryName,
            string leadEngagementPartner,
            string leadEngagementManager);
    }
}
