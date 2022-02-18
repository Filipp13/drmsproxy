namespace CRM.HttpClient
{
    public sealed class ModelForRequest
    {
        public Oppotunity Oppotunity { get; set; }

        public CaseRequestor CaseRequestor { get; set; }

        public LeadEngagementPartner LeadEngagementPartner { get; set; }

        public LeadEngagementManager LeadEngagementManager { get; set; }

        public Product Product { get; set; }

        public ClientMemberFirm ClientMemberFirm { get; set; }

        public Country Country { get; set; }
    }
}