using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{   

    public class CaseRequestorValue: IEntity
    {
        public Guid SystemuserId { get; set; }

        public string? SystemuserIdOData
        {
            get
            {
                return Guid.Empty == SystemuserId ?
                null : $"/systemusers({SystemuserId})";
            }
        }

        public int IdentityId { get; set; }

    }
}