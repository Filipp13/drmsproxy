using System.Text.Json;

namespace CRM.HttpClient
{
    public abstract class LookupModel
    {
        protected LookupModel()
        {
        }

        protected LookupModel(JsonSerializerOptions serializerOptions, string apiVersion)
        {
            SerializerOptions = serializerOptions;
            ApiVersion = apiVersion;
        }

        public JsonSerializerOptions SerializerOptions { get; set; }

        public string ApiVersion { get; set; }

        public abstract string RequestCommand { get; }

        public abstract bool Append(string response, ModelForRequest model);
    }
}