using System.Text.Json;
using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    internal class LookupEntity<TEntity>: ILookupEntity<TEntity> where TEntity : class, IEntity
    {
        private readonly string requestCommand;
        private readonly Action<List<TEntity>, ModelForRequest> predicate;
        private readonly JsonSerializerOptions serializerOptions;

        [JsonConstructor]
        public LookupEntity() { }

        public LookupEntity(
            string requestCommand,
            Action<List<TEntity>, ModelForRequest> predicate)
        {
            this.requestCommand = requestCommand;
            this.predicate = predicate;
            this.serializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
        }

        public string RequestCommand
        {
            get => requestCommand;
        }

        public List<TEntity> Value { get; set; }

        public bool Append(
            string response,
            ModelForRequest model)
        {
            try
            {

                var entity = JsonSerializer.Deserialize<LookupEntity<TEntity>>(response, serializerOptions);
                predicate(entity.Value, model);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
