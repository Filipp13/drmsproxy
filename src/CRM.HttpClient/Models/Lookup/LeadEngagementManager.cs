using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    public class LeadEngagementManager : LookupModel
    {
        string leadEngagementPartner;

        [JsonConstructor]
        public LeadEngagementManager() { }

        public LeadEngagementManager(
          string leadEngagementPartner,
          string apiVersion,
          JsonSerializerOptions serializerOptions) : base(serializerOptions, apiVersion)
        {
            this.leadEngagementPartner = leadEngagementPartner;
            SerializerOptions = serializerOptions;
        }

        public List<LeadEngagementManagerValue> Value { get; set; }

        public override string RequestCommand
        {
            get
            {
                return $"GET /CISIntegra/api/data/{ApiVersion}/systemusers?$select=identityid&$filter=domainname eq '{leadEngagementPartner}' HTTP/1.1";
            }
        }

        public LeadEngagementManagerValue SafeValue
        {
            get
            {
                return Value.Count > 0 ? Value[0] : new LeadEngagementManagerValue();
            }
        }

        public override bool Append(
            string response, 
            ModelForRequest model)
        {
            try
            {

                model.LeadEngagementManager = JsonSerializer.Deserialize<LeadEngagementManager>(response, SerializerOptions);

                return model.LeadEngagementManager.SafeValue.SystemuserIdOData switch
                {
                    null => false,
                    _ => true
                };
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
    }

    public class LeadEngagementManagerValue
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