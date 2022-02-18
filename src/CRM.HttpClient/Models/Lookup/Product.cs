using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    public class Product : LookupModel
    {
        string product;

        [JsonConstructor]
        public Product() { }

        public Product(
          string product,
          string apiVersion,
          JsonSerializerOptions serializerOptions) : base(serializerOptions, apiVersion)
        {
            this.product = product;
            SerializerOptions = serializerOptions;
        }

        public List<ProductValue> Value { get; set; }

        public override string RequestCommand
        {
            get => $"GET /CISIntegra/api/data/{ApiVersion}/nav_oppproducts?$select=nav_oppproductid&$filter=nav_name eq '{product}' HTTP/1.1";
        }

        public ProductValue SafeValue
        {
            get
            {
                return Value.Count > 0 ? Value[0] : new ProductValue();
            }
        }

        public override bool Append(
            string response,
            ModelForRequest model)
        {

            try
            {
                model.Product = JsonSerializer.Deserialize<Product>(response, SerializerOptions);

                return model.Product.SafeValue.ProductIdOData switch
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