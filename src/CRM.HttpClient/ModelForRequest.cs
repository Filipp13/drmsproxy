namespace CRM.HttpClient
{
    public sealed class ModelForRequest
    {
        public OpportunityValue? Oppotunity { get; set; }

        public CaseRequestorValue? CaseRequestor { get; set; }

        public LeadEngagementPartnerValue? LeadEngagementPartner { get; set; }

        public LeadEngagementManagerValue? LeadEngagementManager { get; set; }

        public ProductValue? Product { get; set; }

        public ClientMemberFirmValue? ClientMemberFirm { get; set; }

        public CountryValue? Country { get; set; }
    }
}