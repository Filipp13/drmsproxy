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
                    CaseType.ClientRetentionOnly => DRMSCaseType.ClientandEngagementAcceptance,
                    CaseType.ClientAcceptanceOnly => DRMSCaseType.EngagmentContinuance,
                    CaseType.ClientandEngagementAcceptance => DRMSCaseType.ClientRetentionandEngagementContinuance,
                    CaseType.ClientRetentionandEngagementAcceptance => DRMSCaseType.ClientRetentionandEngagementAcceptance,
                    CaseType.ClientRetentionandEngagementContinuance => DRMSCaseType.ClientRetentionandEngagementAcceptance,
                    CaseType.EngagementAcceptance => DRMSCaseType.ClientRetentionandEngagementAcceptance,
                    CaseType.EngagmentContinuance => DRMSCaseType.ClientRetentionandEngagementAcceptance,
                };
            }
            else { }
        }

        public DRMSCaseType? Value { get; set; }
    }

}