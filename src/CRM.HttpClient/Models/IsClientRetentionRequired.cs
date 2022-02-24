namespace CRM.HttpClient
{
    public class IsClientRetentionRequired
    {
        public IsClientRetentionRequired(bool? isClientRetention)
        {
            Value = isClientRetention;
        }

        public bool? Value { get; set; }
    }

    public enum TwoOption
    {
        No = 0,
        Yes = 1
    }

}