using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    public class ClientMemberFirm : LookupModel
    {
        string clientMemberFirm;

        [JsonConstructor]
        public ClientMemberFirm() { }

        public ClientMemberFirm(
          string clientMemberFirm,
          string apiVersion,
          JsonSerializerOptions serializerOptions) : base(serializerOptions, apiVersion)
        {
            this.clientMemberFirm = clientMemberFirm;
            SerializerOptions = serializerOptions;
        }

        public List<ClientMemberFirmValue> Value { get; set; }

        public override string RequestCommand
        {
            get => $"GET /CISIntegra/api/data/{ApiVersion}/accounts?$select=accountid&$filter=name eq '{clientMemberFirm}' HTTP/1.1";
        }

        public ClientMemberFirmValue SafeValue
        {
            get
            {
                return Value.Count > 0 ? Value[0] : new ClientMemberFirmValue();
            }
        }

        public override bool Append(
            string response,
            ModelForRequest model)
        {

            try
            {

                model.ClientMemberFirm = JsonSerializer.Deserialize<ClientMemberFirm>(response, SerializerOptions);

                return model.ClientMemberFirm.SafeValue.AccountidOData switch
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

    public class ClientMemberFirmValue
    {
        public Guid Accountid { get; set; }

        public string? AccountidOData
        {
            get
            {
                return Guid.Empty == Accountid ?
                 null : $"/accounts({Accountid})";
            }
        }

    }
}