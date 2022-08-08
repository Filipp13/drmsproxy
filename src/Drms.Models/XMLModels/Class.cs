
namespace DRMS.Response
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2003/05/soap-envelope", IsNullable = false)]
    public partial class Envelope
    {

        private EnvelopeHeader headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public EnvelopeHeader Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public partial class EnvelopeHeader
    {

        private HeaderEnvironment headerEnvironmentField;

        private HeaderRequest headerRequestField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/environment")]
        public HeaderEnvironment HeaderEnvironment
        {
            get
            {
                return this.headerEnvironmentField;
            }
            set
            {
                this.headerEnvironmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.deloitte.com/oim-ws/2008/03/transinfo")]
        public HeaderRequest HeaderRequest
        {
            get
            {
                return this.headerRequestField;
            }
            set
            {
                this.headerRequestField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/environment")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/environment", IsNullable = false)]
    public partial class HeaderEnvironment
    {

        private string environmentNameField;

        /// <remarks/>
        public string EnvironmentName
        {
            get
            {
                return this.environmentNameField;
            }
            set
            {
                this.environmentNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.deloitte.com/oim-ws/2008/03/transinfo")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.deloitte.com/oim-ws/2008/03/transinfo", IsNullable = false)]
    public partial class HeaderRequest
    {

        private string systemIDField;

        private string userIDField;

        private string transactionIDField;

        /// <remarks/>
        public string SystemID
        {
            get
            {
                return this.systemIDField;
            }
            set
            {
                this.systemIDField = value;
            }
        }

        /// <remarks/>
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }

        /// <remarks/>
        public string TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
    public partial class EnvelopeBody
    {

        private OriginateCaseOut_Case originateCaseOut_CaseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
        public OriginateCaseOut_Case OriginateCaseOut_Case
        {
            get
            {
                return this.originateCaseOut_CaseField;
            }
            set
            {
                this.originateCaseOut_CaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data", IsNullable = false)]
    public partial class OriginateCaseOut_Case
    {

        private OriginateCaseOut_CaseErrors errorsField;

        /// <remarks/>
        public OriginateCaseOut_CaseErrors Errors
        {
            get
            {
                return this.errorsField;
            }
            set
            {
                this.errorsField = value;
            }
        }

        private CaseResponse caseResponseField;

        public CaseResponse CaseResponse
        {
            get
            {
                return this.caseResponseField;
            }
            set
            {
                this.caseResponseField = value;
            }
        }
    }

    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
    public partial class CaseResponse
    {

        private int caseIdField;

        private CaseType caseTypeField;

        /// <remarks/>
        public int CaseId
        {
            get
            {
                return this.caseIdField;
            }
            set
            {
                this.caseIdField = value;
            }
        }

        /// <remarks/>
        public CaseType CaseType
        {
            get
            {
                return this.caseTypeField;
            }
            set
            {
                this.caseTypeField = value;
            }
        }
    }

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
    public enum CaseType
    {

        /// <remarks/>
        ClientRetentionOnly,

        /// <remarks/>
        ClientAcceptanceOnly,

        /// <remarks/>
        ClientandEngagementAcceptance,

        /// <remarks/>
        ClientRetentionandEngagementAcceptance,

        /// <remarks/>
        ClientRetentionandEngagementContinuance,

        /// <remarks/>
        EngagementAcceptance,

        /// <remarks/>
        EngagmentContinuance,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
    public partial class OriginateCaseOut_CaseErrors
    {

        private OriginateCaseOut_CaseErrorsServiceError serviceErrorField;

        /// <remarks/>
        public OriginateCaseOut_CaseErrorsServiceError ServiceError
        {
            get
            {
                return this.serviceErrorField;
            }
            set
            {
                this.serviceErrorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
    public partial class OriginateCaseOut_CaseErrorsServiceError
    {

        private ushort errorCodeField;

        private string errorMessageField;

        /// <remarks/>
        public ushort ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
    }

}
