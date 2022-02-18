using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    public class CaseRequestor : LookupModel
    {
        string caseRequestor;

        [JsonConstructor]
        public CaseRequestor() { }

        public CaseRequestor(
          string caseRequestor,
          string apiVersion,
          JsonSerializerOptions serializerOptions) : base(serializerOptions, apiVersion)
        {
            this.caseRequestor = caseRequestor;
            SerializerOptions = serializerOptions;
        }

        public List<CaseRequestorValue> Value { get; set; }

        public override string RequestCommand
        {
            get
            {
                return $"GET /CISIntegra/api/data/{ApiVersion}/systemusers?$select=identityid&$filter=domainname eq '{caseRequestor}' HTTP/1.1";
            }
        }

        public CaseRequestorValue SafeValue
        {
            get
            {
                return Value.Count > 0 ? Value[0] : new CaseRequestorValue();
            }
        }

        public override bool Append(
            string response, 
            ModelForRequest model)
        {
            try
            {

                model.CaseRequestor = JsonSerializer.Deserialize<CaseRequestor>(response, SerializerOptions);

                return model.CaseRequestor.SafeValue.SystemuserIdOData switch
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

    public class CaseRequestorValue
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