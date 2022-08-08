using System.Text.Json.Serialization;

namespace CRM.HttpClient
{

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