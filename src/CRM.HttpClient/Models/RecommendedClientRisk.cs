namespace CRM.HttpClient
{
    public class RecommendedClientRisk
    {
        public RecommendedClientRisk(string risk)
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