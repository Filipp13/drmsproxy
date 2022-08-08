using DRMS.Response;

namespace CRM.HttpClient
{
    public class DRMSCase
    {
        public DRMSCase(OriginateCaseOut_Case originateCaseOut)
        {
            if (originateCaseOut is not null
                && originateCaseOut.CaseResponse is not null)
            {
                Value = originateCaseOut.CaseResponse.CaseType switch
                {
                    CaseType.ClientandEngagementAcceptance => DRMSCaseType.ClientandEngagementAcceptance,
                    CaseType.ClientRetentionandEngagementAcceptance => DRMSCaseType.ClientRetentionandEngagementAcceptance,
                    CaseType.ClientRetentionandEngagementContinuance => DRMSCaseType.ClientRetentionandEngagementContinuance,
                    CaseType.EngagementAcceptance => DRMSCaseType.EngagementAcceptance,
                    CaseType.EngagmentContinuance => DRMSCaseType.EngagmentContinuance,
                    _ => null
                };
            }
        }

        public DRMSCaseType? Value { get; set; }
    }

}