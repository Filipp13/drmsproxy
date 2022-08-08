namespace CRM.HttpClient
{
    internal interface ILookupEntity<out TEntity>
    {
        public string RequestCommand { get; }

        public bool Append(string response, ModelForRequest model);
    }
}