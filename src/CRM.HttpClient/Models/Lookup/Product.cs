using System.Text.Json.Serialization;

namespace CRM.HttpClient
{

    public class ProductValue
    {
        [JsonPropertyName("nav_oppproductid")]
        public Guid ProductId { get; set; }

        public string? ProductIdOData
        {
            get
            {
                return Guid.Empty == ProductId ?
                  null : $"/nav_oppproducts({ProductId})";
            }
        }
    }
}