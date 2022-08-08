namespace CRM.HttpClient
{

    public class ClientMemberFirmValue : IEntity
    {
        public Guid Accountid { get; set; }

        public string? AccountidOData
        {
            get
            {
                return Guid.Empty == Accountid ?
                 null : $"/accounts({Accountid})";
            }
        }

    }
}