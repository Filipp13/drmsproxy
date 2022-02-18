using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    public class Oppotunity : LookupModel
    {
        string opportunityName;

        [JsonConstructor]
        public Oppotunity() { }

        public Oppotunity(
            string opportunityName, 
            string apiVersion,
            JsonSerializerOptions serializerOptions) : base(serializerOptions, apiVersion)
        {
            this.opportunityName = opportunityName;
        }

        public List<OppotunityValue>? Value { get; set; }

        public override string RequestCommand
        {
            get
            {
                return $"GET /CISIntegra/api/data/{ApiVersion}/opportunities?$select=opportunityid&$filter=name eq '{opportunityName}' HTTP/1.1";
            }
        }

        public OppotunityValue SafeValue
        {
            get
            {
                return Value.Count > 0 ? Value[0] : new OppotunityValue();
            }
        }

        public override bool Append(
            string response, 
            ModelForRequest model)
        {
            try
            {
                model.Oppotunity = JsonSerializer.Deserialize<Oppotunity>(response, SerializerOptions);

                return model.Oppotunity.SafeValue.OpportunityidOData switch
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

    public class OppotunityValue
    {
        public Guid Opportunityid { get; set; }

        public string? OpportunityidOData
        {
            get
            {
                return Guid.Empty == Opportunityid ?
                    null : $"/opportunities({Opportunityid})";
            }
        }
    }
}