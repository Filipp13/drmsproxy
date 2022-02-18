namespace CRM.HttpClient
{
    public class PublicInterestEntity
    {
        public PublicInterestEntity(string interest)
        {
            Value = interest switch
            {
                "NonPIE" => InterestType.NonPIE,
                "PIEandListed" => InterestType.PIEandListed,
                "PIEandNotListed" => InterestType.PIEandNotListed,
                _ => InterestType.Unknown
            };
        }

        public InterestType Value { get; set; }
    }

}