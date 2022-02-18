namespace CRM.HttpClient
{
    public class RecommendedEngagementRisk
    {
        public RecommendedEngagementRisk(string risk)
        {
            Value = risk switch
            {
                "NormalRisk" => RiskType.NormalRisk,
                "GreateThanNormalRisk" => RiskType.GreateThanNormalRisk,
                "MuchGreaterThanNormalRisk" => RiskType.MuchGreaterThanNormalRisk,
                _ => RiskType.Unknown
            };
        }

        public RiskType Value { get; set; }
    }

}