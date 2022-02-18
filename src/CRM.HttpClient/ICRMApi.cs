using System.Threading.Tasks;

namespace CRM.HttpClient
{
    public interface ICRMApi
    {
        Task<bool> CreateDrmsCase(NewCaseRequest createCaseRequest);

        Task<Guid> GetLookupOppotunityByName(string name);

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
