using CRM.HttpClient;
using Microsoft.Extensions.Options;
using System.Text;
using System.Xml.Serialization;

namespace Drms.Proxy
{
    internal sealed class CRMIntegration : ICRMIntegration
    {
        private readonly ILogger<CRMIntegration> logger;
        private readonly ICRMApi crmApi;
        private readonly CommonOptions options;

        public CRMIntegration(
            ILogger<CRMIntegration> logger,
            ICRMApi crmApi,
            IOptions<CommonOptions> options)
        {
            this.logger = logger;
            this.crmApi = crmApi;
            this.options = options.Value ?? throw new ArgumentNullException(nameof(options));
        }

        public async Task<bool> CreateDrmsCase(byte[] request, byte[] drmsResponse)
        {
            var requestObj = DeserializeStream<DRMSServiceReference.Envelope>(request);
            var modelRequest = requestObj.Body.OriginateCaseIn_Case;

            DRMS.Response.Envelope response = null;
            if (options.EnableProxy)
            {
                logger.LogInformation(Encoding.UTF8.GetString(drmsResponse));
                response = DeserializeStream<DRMS.Response.Envelope>(drmsResponse);
            }
#if DEBUG
                var caseId = 0;

                if (true)
                {
#else
            if (!options.EnableProxy || (response?.Body?.OriginateCaseOut_Case is not null
                && response.Body.OriginateCaseOut_Case.CaseResponse is not null
                && response.Body.OriginateCaseOut_Case.CaseResponse.CaseId > 0))
            {
                var caseId = options.EnableProxy ? response.Body.OriginateCaseOut_Case.CaseResponse.CaseId : 0;
#endif

                var lookups = await crmApi.GetLookups(
                 modelRequest.NewCaseInfoRequest.Opportunity.Name.Value,
                 requestObj.Header.HeaderRequest.UserID,
                 "null",
                 modelRequest.NewCaseInfoRequest.ClientName.Value,
                 "null",
                 modelRequest.EngagementInfo.LeadEnagementPartner.Value,
                 modelRequest.EngagementInfo.LeadEngagementManager.Value);

                if (await crmApi.CreateDrmsCase(new NewCaseRequest(
                    modelRequest.NewCaseInfoRequest.CaseName.Value,
                    caseId,
                    1,
                    lookups.CaseRequestor?.SystemuserIdOData,
                    lookups.Oppotunity?.OpportunityidOData,
                    null!,
                    new IsClientRetentionRequired(modelRequest.NewCaseInfoRequest.IsClientRetentionRequired.Value),
                    new RecommendedClientRisk(modelRequest.NewCaseInfoRequest.RecommendedRiskClassification.RecommendedClientRisk),
                    new RecommendedEngagementRisk(modelRequest.NewCaseInfoRequest.RecommendedRiskClassification.RecommendedEngagementRisk),
                    new PublicInterestEntity(modelRequest.NewCaseInfoRequest.PublicInterestEntity.Value),
                    lookups.LeadEngagementPartner?.SystemuserIdOData,
                    lookups.LeadEngagementManager?.SystemuserIdOData,
                    false,
                    lookups.ClientMemberFirm?.AccountidOData,
                    options.EnableProxy ? 808630000 : 808630004, // draft or approved
                    "",
                    false,
                    modelRequest.EngagementInfo.RatePerHour.Value,
                    modelRequest.EngagementInfo.EngagementDescription.Value,
                    //"",
                    //lookups.Country.SafeValue.CountryIdOData,
                    //(decimal)200.0,
                    //new DRMSCase(response.Body.OriginateCaseOut_Case),
                    string.Format(options.PmpAddress,
                        modelRequest.NewCaseInfoRequest.Opportunity.Id.Value,
                        modelRequest.NewCaseInfoRequest.ClientMemberFirmClientId.Value,
                        modelRequest.NewCaseInfoRequest.ParentCaseId.Value),
                    lookups.CaseRequestor?.SystemuserIdOData,
                    DateTime.Now)
                    ))
                {
                    // ok
                    // log
                    return true;
                }
                else
                {
                    // fail
                    // log
                }
            }
            else
            {
                // log
            }

            return false;
        }

        
        private T DeserializeStream<T>(byte[] bytes)
        {
            using (Stream stream = new MemoryStream(bytes))
            {
                var mySerializer = new XmlSerializer(typeof(T));
                return (T)mySerializer.Deserialize(stream);
            }
        }

        //private IEnumerable<XElement> FindDescendants(XElement xElement, string elementName)
        //{
        //    var result = xElement.Descendants().Where(ele => ele.Name.LocalName == elementName);
        //    return result;
        //}
    }
}
