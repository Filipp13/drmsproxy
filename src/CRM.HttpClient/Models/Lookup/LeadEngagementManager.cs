namespace CRM.HttpClient
{

    public class LeadEngagementManagerValue : IEntity
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