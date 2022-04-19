using System.Text.Json.Serialization;

namespace CRM.HttpClient
{
    public record NewCaseRequest
    {
        public NewCaseRequest(
            string name, 
            //int caseId, 
            int statusCode, 
            string? caseRequestor,
            string? opportunity,
            string? oppproductId,
            IsClientRetentionRequired isClientRetentionRequired,
            RecommendedClientRisk recommendedClientRisk,
            RecommendedEngagementRisk recommendedEngagementRisk,
            PublicInterestEntity publicInterestEntity,
            string? leadEngagementPartner,
            string? leadEngagementManager,
            bool isThisEngagementReferral,
            string? accountId,
            int status, 
            string descriptionOfBusinessOperations,
            bool drmsClient,
            double? ratePerHour, 
            string drmsDescription,
            //string lcspId,
            //string? country,
            //decimal aggregateFee,
            //DRMSCase drmsCase,
            string linkToPMP,
            string? owner,
            DateTime statusDate)
        {
            Name = name;
            //CaseId = caseId;
            StatusCode = statusCode;
            CaseRequestor = caseRequestor;
            Opportunity = opportunity;
            OppproductId = oppproductId;
            IsClientRetentionRequired = isClientRetentionRequired.Value;
            RecommendedClientRisk = (int)recommendedClientRisk.Value;
            RecommendedEngagementRisk = (int)recommendedEngagementRisk.Value;
            PublicInterestEntity = (int)publicInterestEntity.Value;
            LeadEngagementPartner = leadEngagementPartner;
            LeadEngagementManager = leadEngagementManager;
            IsThisEngagementReferral = isThisEngagementReferral;
            AccountId = accountId;
            Status = status;
            DescriptionOfBusinessOperations = descriptionOfBusinessOperations;
            DrmsClient = drmsClient;
            RatePerHour = ratePerHour;
            DrmsDescription = drmsDescription;
            //LcspId = lcspId;
            //Country = country;
            //AggregateFee = aggregateFee;
            //DRMSCaseType = drmsCase.Value is null ? null! : (int)drmsCase.Value;
            LinkToPMP = linkToPMP;
            Owner = owner;
            StatusDate = statusDate;
        }

        [JsonPropertyName("nav_name")]
        public string Name { get; }

        //[JsonPropertyName("nav_caseid")]
        //public int CaseId { get; }

        [JsonPropertyName("statuscode")]
        public int StatusCode { get; }

        [JsonPropertyName("nav_caserequestor@odata.bind")]
        public string? CaseRequestor { get; }

        [JsonPropertyName("nav_opportunity@odata.bind")]
        public string? Opportunity { get; }

        [JsonPropertyName("nav_oppproductid@odata.bind")]
        public string? OppproductId { get; }

        [JsonPropertyName("nav_isclientretentionrequired")]
        public bool? IsClientRetentionRequired { get; }

        [JsonPropertyName("nav_recclientrisk")]
        public int RecommendedClientRisk { get; }

        [JsonPropertyName("nav_recengagementrisk")]
        public int RecommendedEngagementRisk { get; }

        [JsonPropertyName("new_publicinterestentity")]
        public int PublicInterestEntity { get; }

        [JsonPropertyName("new_isthisengagementreferral")]
        public bool IsThisEngagementReferral { get; }

        [JsonPropertyName("nav_accountid@odata.bind")]
        public string? AccountId { get; }

        [JsonPropertyName("nav_status")]
        public int Status { get; }

        [JsonPropertyName("new_descriptionofbusinessoperations")]
        public string DescriptionOfBusinessOperations { get; }

        [JsonPropertyName("nav_drmsclient")]
        public bool DrmsClient { get; }

        [JsonPropertyName("new_rateperhour")]
        public double? RatePerHour { get; }

        [JsonPropertyName("nav_drmsdescription")]
        public string DrmsDescription { get; }

        [JsonPropertyName("nav_servicelinepartnerid@odata.bind")]
        public string? LeadEngagementPartner { get; }

        [JsonPropertyName("new_LeadEngagementManager@odata.bind")]
        public string? LeadEngagementManager { get; }

        //[JsonPropertyName("new_indicatefeebasisforthisengagement")]
        //public Guid IndicateFeeBasisForThisEngagement { get; }

        //[JsonPropertyName("nav_lcspid")]
        //public string LcspId { get; }

        //[JsonPropertyName("nav_country@odata.bind")]
        //public string? Country { get; }

        //[JsonPropertyName("nav_aggregatefee")]
        //public decimal AggregateFee { get; }

        //[JsonPropertyName("nav_type")]
        //public int? DRMSCaseType { get; }

        [JsonPropertyName("dlt_linktopmp")]
        public string? LinkToPMP { get; }

        [JsonPropertyName("ownerid@odata.bind")]
        public string? Owner { get; }

        [JsonPropertyName("nav_datestatus")]
        public DateTime StatusDate { get; }
    }
}
