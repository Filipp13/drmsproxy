namespace CRM.HttpClient
{

    public class LeadEngagementPartnerValue: IEntity
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

    }
}