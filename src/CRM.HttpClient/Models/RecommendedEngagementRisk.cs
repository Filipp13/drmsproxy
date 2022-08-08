using DRMSServiceReference;

namespace CRM.HttpClient
{
    public class RecommendedEngagementRisk
    {
        public RecommendedEngagementRisk(RiskClassification riskClassification)
        {
            Value = riskClassification switch
            {
                RiskClassification.NormalRisk => RiskType.NormalRisk,
                RiskClassification.GreaterThanNormalRisk => RiskType.GreateThanNormalRisk,
                RiskClassification.MuchGreaterThanNormalRisk => RiskType.MuchGreaterThanNormalRisk,
                _ => RiskType.Unknown
            };
        }

        public RiskType Value { get; set; }
    }

}