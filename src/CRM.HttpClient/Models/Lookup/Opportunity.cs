namespace CRM.HttpClient
{

    public class OpportunityValue: IEntity
    {
        public Guid Opportunityid { get; set; }

        public string? OpportunityidOData
        {
            get
            {
                return Guid.Empty == Opportunityid ?
                    null : $"/opportunities({Opportunityid})";
            }
        }
    }
}