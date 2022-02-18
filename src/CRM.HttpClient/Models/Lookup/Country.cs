using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    public class Country : LookupModel
    {
        string country;

        [JsonConstructor]
        public Country() { }

        public Country(
          string country,
          string apiVersion,
          JsonSerializerOptions serializerOptions) : base(serializerOptions, apiVersion)
        {
            this.country = country;
            SerializerOptions = serializerOptions;
        }

        public List<CountryValue> Value { get; set; }

        public override string RequestCommand
        {
            get => $"GET /CISIntegra/api/data/{ApiVersion}/nav_countries?$select=nav_countryid&$filter=nav_name eq '{country}' HTTP/1.1";
        }

        public CountryValue SafeValue
        {
            get
            {
                return Value.Count > 0 ? Value[0] : new CountryValue();
            }
        }

        public override bool Append(
            string response,
            ModelForRequest model)
        {
            try
            {

                model.Country = JsonSerializer.Deserialize<Country>(response, SerializerOptions);

                return model.Country.SafeValue.CountryIdOData switch
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

    public class CountryValue
    {
        [JsonPropertyName("nav_countryid")]
        public Guid CountryId { get; set; }

        public string? CountryIdOData
        {
            get
            {
                return Guid.Empty == CountryId ?
                  null : $"/nav_countries({CountryId})";
            }
        }

    }
}