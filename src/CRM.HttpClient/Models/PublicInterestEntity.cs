using DRMSServiceReference;

namespace CRM.HttpClient
{
    public class PublicInterestEntity
    {
        public PublicInterestEntity(PIEType? pIEType)
        {
            Value = pIEType switch
            {
                PIEType.NonPIE => InterestType.NonPIE,
                PIEType.PIEandListed => InterestType.PIEandListed,
                PIEType.PIEandNotListed => InterestType.PIEandNotListed,
                _ => InterestType.Unknown
            };
        }

        public InterestType Value { get; set; }
    }

}