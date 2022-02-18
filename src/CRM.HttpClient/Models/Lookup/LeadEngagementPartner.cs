using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    public class LeadEngagementPartner : LookupModel
    {
        string leadEngagementPartner;

        [JsonConstructor]
        public LeadEngagementPartner() { }

        public LeadEngagementPartner(
          string leadEngagementPartner,
          string apiVersion,
          JsonSerializerOptions serializerOptions) : base(serializerOptions, apiVersion)
        {
            this.leadEngagementPartner = leadEngagementPartner;
            SerializerOptions = serializerOptions;
        }

        public List<LeadEngagementPartnerValue> Value { get; set; }

        public override string RequestCommand
        {
            get
            {
                return $"GET /CISIntegra/api/data/{ApiVersion}/systemusers?$select=identityid&$filter=domainname eq '{leadEngagementPartner}' HTTP/1.1";
            }
        }

        public LeadEngagementPartnerValue SafeValue
        {
            get
            {
                return Value.Count > 0 ? Value[0] : new LeadEngagementPartnerValue();
            }
        }

        public override bool Append(
            string response, 
            ModelForRequest model)
        {
            try
            {

                model.LeadEngagementPartner = JsonSerializer.Deserialize<LeadEngagementPartner>(response, SerializerOptions);

                return model.LeadEngagementPartner.SafeValue.SystemuserIdOData switch
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

    public class LeadEngagementPartnerValue
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

    }
}