//namespace DRMS.Request
//{
//    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2003/05/soap-envelope", IsNullable = false)]
//    public class Envelope
//    {

//        private EnvelopeHeader headerField;

//        private EnvelopeBody bodyField;

//        /// <remarks/>
//        public EnvelopeHeader Header
//        {
//            get
//            {
//                return this.headerField;
//            }
//            set
//            {
//                this.headerField = value;
//            }
//        }

//        /// <remarks/>
//        public EnvelopeBody Body
//        {
//            get
//            {
//                return this.bodyField;
//            }
//            set
//            {
//                this.bodyField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
//    public partial class EnvelopeHeader
//    {

//        private HeaderEnvironment headerEnvironmentField;

//        private HeaderRequest headerRequestField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/environment")]
//        public HeaderEnvironment HeaderEnvironment
//        {
//            get
//            {
//                return this.headerEnvironmentField;
//            }
//            set
//            {
//                this.headerEnvironmentField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.deloitte.com/oim-ws/2008/03/transinfo")]
//        public HeaderRequest HeaderRequest
//        {
//            get
//            {
//                return this.headerRequestField;
//            }
//            set
//            {
//                this.headerRequestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/environment")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/environment", IsNullable = false)]
//    public partial class HeaderEnvironment
//    {

//        private string environmentNameField;

//        /// <remarks/>
//        public string EnvironmentName
//        {
//            get
//            {
//                return this.environmentNameField;
//            }
//            set
//            {
//                this.environmentNameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.deloitte.com/oim-ws/2008/03/transinfo")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.deloitte.com/oim-ws/2008/03/transinfo", IsNullable = false)]
//    public partial class HeaderRequest
//    {

//        private string systemIDField;

//        private string userIDField;

//        /// <remarks/>
//        public string SystemID
//        {
//            get
//            {
//                return this.systemIDField;
//            }
//            set
//            {
//                this.systemIDField = value;
//            }
//        }

//        /// <remarks/>
//        public string UserID
//        {
//            get
//            {
//                return this.userIDField;
//            }
//            set
//            {
//                this.userIDField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2003/05/soap-envelope")]
//    public partial class EnvelopeBody
//    {

//        private OriginateCaseIn_Case originateCaseIn_CaseField;

//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//        public OriginateCaseIn_Case OriginateCaseIn_Case
//        {
//            get
//            {
//                return this.originateCaseIn_CaseField;
//            }
//            set
//            {
//                this.originateCaseIn_CaseField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data", IsNullable = false)]
//    public partial class OriginateCaseIn_Case
//    {

//        private OriginateCaseIn_CaseNewCaseInfoRequest newCaseInfoRequestField;

//        private OriginateCaseIn_CaseEngagementInfo engagementInfoField;

//        private OriginateCaseIn_CaseClientInfo clientInfoField;

//        private OriginateCaseIn_CaseKnowYourClientInfo knowYourClientInfoField;

//        private OriginateCaseIn_CaseConflictCheckInfo conflictCheckInfoField;

//        private OriginateCaseIn_CaseIndependenceCheckInfo independenceCheckInfoField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequest NewCaseInfoRequest
//        {
//            get
//            {
//                return this.newCaseInfoRequestField;
//            }
//            set
//            {
//                this.newCaseInfoRequestField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfo EngagementInfo
//        {
//            get
//            {
//                return this.engagementInfoField;
//            }
//            set
//            {
//                this.engagementInfoField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfo ClientInfo
//        {
//            get
//            {
//                return this.clientInfoField;
//            }
//            set
//            {
//                this.clientInfoField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfo KnowYourClientInfo
//        {
//            get
//            {
//                return this.knowYourClientInfoField;
//            }
//            set
//            {
//                this.knowYourClientInfoField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseConflictCheckInfo ConflictCheckInfo
//        {
//            get
//            {
//                return this.conflictCheckInfoField;
//            }
//            set
//            {
//                this.conflictCheckInfoField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseIndependenceCheckInfo IndependenceCheckInfo
//        {
//            get
//            {
//                return this.independenceCheckInfoField;
//            }
//            set
//            {
//                this.independenceCheckInfoField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequest
//    {

//        private OriginateCaseIn_CaseNewCaseInfoRequestCaseName caseNameField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestCountryId countryIdField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestEnforceDuplicateCaseName enforceDuplicateCaseNameField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestClientMemberFirmClientId clientMemberFirmClientIdField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestMemberFirmLCSP memberFirmLCSPField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestIsClientRetentionRequired isClientRetentionRequiredField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestIsEngagement isEngagementField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestClientName clientNameField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestEnforceDuplicateClientName enforceDuplicateClientNameField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestClientCountryOfDomicileId clientCountryOfDomicileIdField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestTargetApprovalDate targetApprovalDateField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestGlobalServiceOfferingId globalServiceOfferingIdField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestParentCaseId parentCaseIdField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestIsIFWRReceived isIFWRReceivedField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestIsRelyingOnIFWR isRelyingOnIFWRField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequest[] teammembersField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestOpportunity opportunityField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestRecommendedRiskClassification recommendedRiskClassificationField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestPublicInterestEntity publicInterestEntityField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestIsEligibleForSFR isEligibleForSFRField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestIsSFRUsed isSFRUsedField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestDgmfId dgmfIdField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestEntityType entityTypeField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestCaseName CaseName
//        {
//            get
//            {
//                return this.caseNameField;
//            }
//            set
//            {
//                this.caseNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestCountryId CountryId
//        {
//            get
//            {
//                return this.countryIdField;
//            }
//            set
//            {
//                this.countryIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestEnforceDuplicateCaseName EnforceDuplicateCaseName
//        {
//            get
//            {
//                return this.enforceDuplicateCaseNameField;
//            }
//            set
//            {
//                this.enforceDuplicateCaseNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestClientMemberFirmClientId ClientMemberFirmClientId
//        {
//            get
//            {
//                return this.clientMemberFirmClientIdField;
//            }
//            set
//            {
//                this.clientMemberFirmClientIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestMemberFirmLCSP MemberFirmLCSP
//        {
//            get
//            {
//                return this.memberFirmLCSPField;
//            }
//            set
//            {
//                this.memberFirmLCSPField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestIsClientRetentionRequired IsClientRetentionRequired
//        {
//            get
//            {
//                return this.isClientRetentionRequiredField;
//            }
//            set
//            {
//                this.isClientRetentionRequiredField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestIsEngagement IsEngagement
//        {
//            get
//            {
//                return this.isEngagementField;
//            }
//            set
//            {
//                this.isEngagementField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestClientName ClientName
//        {
//            get
//            {
//                return this.clientNameField;
//            }
//            set
//            {
//                this.clientNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestEnforceDuplicateClientName EnforceDuplicateClientName
//        {
//            get
//            {
//                return this.enforceDuplicateClientNameField;
//            }
//            set
//            {
//                this.enforceDuplicateClientNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestClientCountryOfDomicileId ClientCountryOfDomicileId
//        {
//            get
//            {
//                return this.clientCountryOfDomicileIdField;
//            }
//            set
//            {
//                this.clientCountryOfDomicileIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestTargetApprovalDate TargetApprovalDate
//        {
//            get
//            {
//                return this.targetApprovalDateField;
//            }
//            set
//            {
//                this.targetApprovalDateField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestGlobalServiceOfferingId GlobalServiceOfferingId
//        {
//            get
//            {
//                return this.globalServiceOfferingIdField;
//            }
//            set
//            {
//                this.globalServiceOfferingIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestParentCaseId ParentCaseId
//        {
//            get
//            {
//                return this.parentCaseIdField;
//            }
//            set
//            {
//                this.parentCaseIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestIsIFWRReceived IsIFWRReceived
//        {
//            get
//            {
//                return this.isIFWRReceivedField;
//            }
//            set
//            {
//                this.isIFWRReceivedField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestIsRelyingOnIFWR IsRelyingOnIFWR
//        {
//            get
//            {
//                return this.isRelyingOnIFWRField;
//            }
//            set
//            {
//                this.isRelyingOnIFWRField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItemAttribute("TeamMemberRequest", IsNullable = false)]
//        public OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequest[] Teammembers
//        {
//            get
//            {
//                return this.teammembersField;
//            }
//            set
//            {
//                this.teammembersField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestOpportunity Opportunity
//        {
//            get
//            {
//                return this.opportunityField;
//            }
//            set
//            {
//                this.opportunityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestRecommendedRiskClassification RecommendedRiskClassification
//        {
//            get
//            {
//                return this.recommendedRiskClassificationField;
//            }
//            set
//            {
//                this.recommendedRiskClassificationField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestPublicInterestEntity PublicInterestEntity
//        {
//            get
//            {
//                return this.publicInterestEntityField;
//            }
//            set
//            {
//                this.publicInterestEntityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestIsEligibleForSFR IsEligibleForSFR
//        {
//            get
//            {
//                return this.isEligibleForSFRField;
//            }
//            set
//            {
//                this.isEligibleForSFRField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestIsSFRUsed IsSFRUsed
//        {
//            get
//            {
//                return this.isSFRUsedField;
//            }
//            set
//            {
//                this.isSFRUsedField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestDgmfId DgmfId
//        {
//            get
//            {
//                return this.dgmfIdField;
//            }
//            set
//            {
//                this.dgmfIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestEntityType EntityType
//        {
//            get
//            {
//                return this.entityTypeField;
//            }
//            set
//            {
//                this.entityTypeField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestCaseName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestCountryId
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestEnforceDuplicateCaseName
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestClientMemberFirmClientId
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestMemberFirmLCSP
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestIsClientRetentionRequired
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestIsEngagement
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestClientName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestEnforceDuplicateClientName
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestClientCountryOfDomicileId
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTargetApprovalDate
//    {

//        private System.DateTime valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public System.DateTime Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestGlobalServiceOfferingId
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestParentCaseId
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestIsIFWRReceived
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestIsRelyingOnIFWR
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequest
//    {

//        private OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestTeamMemberADName teamMemberADNameField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestInstructions instructionsField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsAdministrator isAdministratorField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsApprovalEmailRequired isApprovalEmailRequiredField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsReworkEmailRequired isReworkEmailRequiredField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsConflictCheckRequestStatusChangeEmailRequired isConflictCheckRequestStatusChangeEmailRequiredField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsServiceRequestStatusChangeEmailRequired isServiceRequestStatusChangeEmailRequiredField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestTeamMemberADName TeamMemberADName
//        {
//            get
//            {
//                return this.teamMemberADNameField;
//            }
//            set
//            {
//                this.teamMemberADNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestInstructions Instructions
//        {
//            get
//            {
//                return this.instructionsField;
//            }
//            set
//            {
//                this.instructionsField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsAdministrator IsAdministrator
//        {
//            get
//            {
//                return this.isAdministratorField;
//            }
//            set
//            {
//                this.isAdministratorField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsApprovalEmailRequired IsApprovalEmailRequired
//        {
//            get
//            {
//                return this.isApprovalEmailRequiredField;
//            }
//            set
//            {
//                this.isApprovalEmailRequiredField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsReworkEmailRequired IsReworkEmailRequired
//        {
//            get
//            {
//                return this.isReworkEmailRequiredField;
//            }
//            set
//            {
//                this.isReworkEmailRequiredField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsConflictCheckRequestStatusChangeEmailRequired IsConflictCheckRequestStatusChangeEmailRequired
//        {
//            get
//            {
//                return this.isConflictCheckRequestStatusChangeEmailRequiredField;
//            }
//            set
//            {
//                this.isConflictCheckRequestStatusChangeEmailRequiredField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsServiceRequestStatusChangeEmailRequired IsServiceRequestStatusChangeEmailRequired
//        {
//            get
//            {
//                return this.isServiceRequestStatusChangeEmailRequiredField;
//            }
//            set
//            {
//                this.isServiceRequestStatusChangeEmailRequiredField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestTeamMemberADName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestInstructions
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsAdministrator
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsApprovalEmailRequired
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsReworkEmailRequired
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsConflictCheckRequestStatusChangeEmailRequired
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestTeamMemberRequestIsServiceRequestStatusChangeEmailRequired
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestOpportunity
//    {

//        private OriginateCaseIn_CaseNewCaseInfoRequestOpportunityID idField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestOpportunityName nameField;

//        private OriginateCaseIn_CaseNewCaseInfoRequestOpportunityUrl urlField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestOpportunityID Id
//        {
//            get
//            {
//                return this.idField;
//            }
//            set
//            {
//                this.idField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestOpportunityName Name
//        {
//            get
//            {
//                return this.nameField;
//            }
//            set
//            {
//                this.nameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseNewCaseInfoRequestOpportunityUrl Url
//        {
//            get
//            {
//                return this.urlField;
//            }
//            set
//            {
//                this.urlField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestOpportunityID
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestOpportunityName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestOpportunityUrl
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestRecommendedRiskClassification
//    {

//        private string recommendedClientRiskField;

//        private bool isClientRiskOverriddenField;

//        private string recommendedEngagementRiskField;

//        private bool isEngagementRiskOverriddenField;

//        /// <remarks/>
//        public string RecommendedClientRisk
//        {
//            get
//            {
//                return this.recommendedClientRiskField;
//            }
//            set
//            {
//                this.recommendedClientRiskField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsClientRiskOverridden
//        {
//            get
//            {
//                return this.isClientRiskOverriddenField;
//            }
//            set
//            {
//                this.isClientRiskOverriddenField = value;
//            }
//        }

//        /// <remarks/>
//        public string RecommendedEngagementRisk
//        {
//            get
//            {
//                return this.recommendedEngagementRiskField;
//            }
//            set
//            {
//                this.recommendedEngagementRiskField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsEngagementRiskOverridden
//        {
//            get
//            {
//                return this.isEngagementRiskOverriddenField;
//            }
//            set
//            {
//                this.isEngagementRiskOverriddenField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestPublicInterestEntity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestIsEligibleForSFR
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestIsSFRUsed
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestDgmfId
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseNewCaseInfoRequestEntityType
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfo
//    {

//        private OriginateCaseIn_CaseEngagementInfoPrimaryPerformingOffice primaryPerformingOfficeField;

//        private OriginateCaseIn_CaseEngagementInfoEngagementDescription engagementDescriptionField;

//        private OriginateCaseIn_CaseEngagementInfoGlobalServiceOfferingOther globalServiceOfferingOtherField;

//        private OriginateCaseIn_CaseEngagementInfoWasContingencyFeeReviewed wasContingencyFeeReviewedField;

//        private OriginateCaseIn_CaseEngagementInfoOtherFeeArrangement otherFeeArrangementField;

//        private OriginateCaseIn_CaseEngagementInfoEstimatedFees estimatedFeesField;

//        private OriginateCaseIn_CaseEngagementInfoCurrency currencyField;

//        private OriginateCaseIn_CaseEngagementInfoRatePerHour ratePerHourField;

//        private OriginateCaseIn_CaseEngagementInfoHoursProjected hoursProjectedField;

//        private OriginateCaseIn_CaseEngagementInfoExpectedRecovery expectedRecoveryField;

//        private OriginateCaseIn_CaseEngagementInfoLeadEnagementPartner leadEnagementPartnerField;

//        private OriginateCaseIn_CaseEngagementInfoLeadEngagementManager leadEngagementManagerField;

//        private OriginateCaseIn_CaseEngagementInfoEnagementTeamMembers enagementTeamMembersField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagement additionalPartiesToEngagementField;

//        private OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequest[] otherParticipatingFunctionsField;

//        private OriginateCaseIn_CaseEngagementInfoMemberFirmServiceOffering memberFirmServiceOfferingField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoPrimaryPerformingOffice PrimaryPerformingOffice
//        {
//            get
//            {
//                return this.primaryPerformingOfficeField;
//            }
//            set
//            {
//                this.primaryPerformingOfficeField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEngagementDescription EngagementDescription
//        {
//            get
//            {
//                return this.engagementDescriptionField;
//            }
//            set
//            {
//                this.engagementDescriptionField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoGlobalServiceOfferingOther GlobalServiceOfferingOther
//        {
//            get
//            {
//                return this.globalServiceOfferingOtherField;
//            }
//            set
//            {
//                this.globalServiceOfferingOtherField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoWasContingencyFeeReviewed WasContingencyFeeReviewed
//        {
//            get
//            {
//                return this.wasContingencyFeeReviewedField;
//            }
//            set
//            {
//                this.wasContingencyFeeReviewedField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoOtherFeeArrangement OtherFeeArrangement
//        {
//            get
//            {
//                return this.otherFeeArrangementField;
//            }
//            set
//            {
//                this.otherFeeArrangementField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEstimatedFees EstimatedFees
//        {
//            get
//            {
//                return this.estimatedFeesField;
//            }
//            set
//            {
//                this.estimatedFeesField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoCurrency Currency
//        {
//            get
//            {
//                return this.currencyField;
//            }
//            set
//            {
//                this.currencyField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoRatePerHour RatePerHour
//        {
//            get
//            {
//                return this.ratePerHourField;
//            }
//            set
//            {
//                this.ratePerHourField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoHoursProjected HoursProjected
//        {
//            get
//            {
//                return this.hoursProjectedField;
//            }
//            set
//            {
//                this.hoursProjectedField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoExpectedRecovery ExpectedRecovery
//        {
//            get
//            {
//                return this.expectedRecoveryField;
//            }
//            set
//            {
//                this.expectedRecoveryField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoLeadEnagementPartner LeadEnagementPartner
//        {
//            get
//            {
//                return this.leadEnagementPartnerField;
//            }
//            set
//            {
//                this.leadEnagementPartnerField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoLeadEngagementManager LeadEngagementManager
//        {
//            get
//            {
//                return this.leadEngagementManagerField;
//            }
//            set
//            {
//                this.leadEngagementManagerField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEnagementTeamMembers EnagementTeamMembers
//        {
//            get
//            {
//                return this.enagementTeamMembersField;
//            }
//            set
//            {
//                this.enagementTeamMembersField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagement AdditionalPartiesToEngagement
//        {
//            get
//            {
//                return this.additionalPartiesToEngagementField;
//            }
//            set
//            {
//                this.additionalPartiesToEngagementField = value;
//            }
//        }

//        /// <remarks/>
//        [System.Xml.Serialization.XmlArrayItemAttribute("OtherParticipatingFunctionRequest", IsNullable = false)]
//        public OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequest[] OtherParticipatingFunctions
//        {
//            get
//            {
//                return this.otherParticipatingFunctionsField;
//            }
//            set
//            {
//                this.otherParticipatingFunctionsField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoMemberFirmServiceOffering MemberFirmServiceOffering
//        {
//            get
//            {
//                return this.memberFirmServiceOfferingField;
//            }
//            set
//            {
//                this.memberFirmServiceOfferingField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoPrimaryPerformingOffice
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEngagementDescription
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoGlobalServiceOfferingOther
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoWasContingencyFeeReviewed
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoOtherFeeArrangement
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEstimatedFees
//    {

//        private int valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public int Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoCurrency
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoRatePerHour
//    {

//        private int valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public int Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoHoursProjected
//    {

//        private int valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public int Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoExpectedRecovery
//    {

//        private int valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public int Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoLeadEnagementPartner
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoLeadEngagementManager
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEnagementTeamMembers
//    {

//        private OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequest enagementTeamMemberRequestField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequest EnagementTeamMemberRequest
//        {
//            get
//            {
//                return this.enagementTeamMemberRequestField;
//            }
//            set
//            {
//                this.enagementTeamMemberRequestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequest
//    {

//        private OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestADUserName aDUserNameField;

//        private OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestEngagementRole engagementRoleField;

//        private OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestYearsOfExperienceWithClient yearsOfExperienceWithClientField;

//        private OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestYearsOfExperienceInIndustry yearsOfExperienceInIndustryField;

//        private OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestSpecialistSkills specialistSkillsField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestADUserName ADUserName
//        {
//            get
//            {
//                return this.aDUserNameField;
//            }
//            set
//            {
//                this.aDUserNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestEngagementRole EngagementRole
//        {
//            get
//            {
//                return this.engagementRoleField;
//            }
//            set
//            {
//                this.engagementRoleField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestYearsOfExperienceWithClient YearsOfExperienceWithClient
//        {
//            get
//            {
//                return this.yearsOfExperienceWithClientField;
//            }
//            set
//            {
//                this.yearsOfExperienceWithClientField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestYearsOfExperienceInIndustry YearsOfExperienceInIndustry
//        {
//            get
//            {
//                return this.yearsOfExperienceInIndustryField;
//            }
//            set
//            {
//                this.yearsOfExperienceInIndustryField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestSpecialistSkills SpecialistSkills
//        {
//            get
//            {
//                return this.specialistSkillsField;
//            }
//            set
//            {
//                this.specialistSkillsField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestADUserName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestEngagementRole
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestYearsOfExperienceWithClient
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestYearsOfExperienceInIndustry
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoEnagementTeamMembersEnagementTeamMemberRequestSpecialistSkills
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagement
//    {

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividuals individualsField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompanies companiesField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividuals Individuals
//        {
//            get
//            {
//                return this.individualsField;
//            }
//            set
//            {
//                this.individualsField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompanies Companies
//        {
//            get
//            {
//                return this.companiesField;
//            }
//            set
//            {
//                this.companiesField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividuals
//    {

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequest individualRequestField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequest IndividualRequest
//        {
//            get
//            {
//                return this.individualRequestField;
//            }
//            set
//            {
//                this.individualRequestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequest
//    {

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestDgmfId dgmfIdField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestLastName lastNameField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestFirstName firstNameField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAliasLastName aliasLastNameField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAliasFirstName aliasFirstNameField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestPersonalTitle personalTitleField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestBusinessTitle businessTitleField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestDateOfBirth dateOfBirthField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestGender genderField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCitizenShip citizenShipField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAddress addressField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCountry countryField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCity cityField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestPartyType partyTypeField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestRelationShipIndiviualToClient relationShipIndiviualToClientField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestInvolvementIndividualToEngagement involvementIndividualToEngagementField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestDgmfId DgmfId
//        {
//            get
//            {
//                return this.dgmfIdField;
//            }
//            set
//            {
//                this.dgmfIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestLastName LastName
//        {
//            get
//            {
//                return this.lastNameField;
//            }
//            set
//            {
//                this.lastNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestFirstName FirstName
//        {
//            get
//            {
//                return this.firstNameField;
//            }
//            set
//            {
//                this.firstNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAliasLastName AliasLastName
//        {
//            get
//            {
//                return this.aliasLastNameField;
//            }
//            set
//            {
//                this.aliasLastNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAliasFirstName AliasFirstName
//        {
//            get
//            {
//                return this.aliasFirstNameField;
//            }
//            set
//            {
//                this.aliasFirstNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestPersonalTitle PersonalTitle
//        {
//            get
//            {
//                return this.personalTitleField;
//            }
//            set
//            {
//                this.personalTitleField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestBusinessTitle BusinessTitle
//        {
//            get
//            {
//                return this.businessTitleField;
//            }
//            set
//            {
//                this.businessTitleField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestDateOfBirth DateOfBirth
//        {
//            get
//            {
//                return this.dateOfBirthField;
//            }
//            set
//            {
//                this.dateOfBirthField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestGender Gender
//        {
//            get
//            {
//                return this.genderField;
//            }
//            set
//            {
//                this.genderField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCitizenShip CitizenShip
//        {
//            get
//            {
//                return this.citizenShipField;
//            }
//            set
//            {
//                this.citizenShipField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAddress Address
//        {
//            get
//            {
//                return this.addressField;
//            }
//            set
//            {
//                this.addressField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCountry Country
//        {
//            get
//            {
//                return this.countryField;
//            }
//            set
//            {
//                this.countryField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCity City
//        {
//            get
//            {
//                return this.cityField;
//            }
//            set
//            {
//                this.cityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestPartyType PartyType
//        {
//            get
//            {
//                return this.partyTypeField;
//            }
//            set
//            {
//                this.partyTypeField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestRelationShipIndiviualToClient RelationShipIndiviualToClient
//        {
//            get
//            {
//                return this.relationShipIndiviualToClientField;
//            }
//            set
//            {
//                this.relationShipIndiviualToClientField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestInvolvementIndividualToEngagement InvolvementIndividualToEngagement
//        {
//            get
//            {
//                return this.involvementIndividualToEngagementField;
//            }
//            set
//            {
//                this.involvementIndividualToEngagementField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestDgmfId
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestLastName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestFirstName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAliasLastName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAliasFirstName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestPersonalTitle
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestBusinessTitle
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestDateOfBirth
//    {

//        private System.DateTime valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public System.DateTime Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestGender
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCitizenShip
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestAddress
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCountry
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestCity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestPartyType
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestRelationShipIndiviualToClient
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementIndividualsIndividualRequestInvolvementIndividualToEngagement
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompanies
//    {

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequest companyRequestField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequest CompanyRequest
//        {
//            get
//            {
//                return this.companyRequestField;
//            }
//            set
//            {
//                this.companyRequestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequest
//    {

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestDgmfId dgmfIdField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCompanyName companyNameField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCountryOfIncorporation countryOfIncorporationField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestDateOfIncorporation dateOfIncorporationField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestPreviousCompanyName previousCompanyNameField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestAddress addressField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCountry countryField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCity cityField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestIndustrySector industrySectorField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestTypeOfEntity typeOfEntityField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestOwnershipOfEntity ownershipOfEntityField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestEntityTypeAndOwnershipDescription entityTypeAndOwnershipDescriptionField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestPartyType partyTypeField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestRelationShipEntityToOtherParties relationShipEntityToOtherPartiesField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestRelationShipEntityToEngagement relationShipEntityToEngagementField;

//        private OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestOtherInformation otherInformationField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestDgmfId DgmfId
//        {
//            get
//            {
//                return this.dgmfIdField;
//            }
//            set
//            {
//                this.dgmfIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCompanyName CompanyName
//        {
//            get
//            {
//                return this.companyNameField;
//            }
//            set
//            {
//                this.companyNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCountryOfIncorporation CountryOfIncorporation
//        {
//            get
//            {
//                return this.countryOfIncorporationField;
//            }
//            set
//            {
//                this.countryOfIncorporationField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestDateOfIncorporation DateOfIncorporation
//        {
//            get
//            {
//                return this.dateOfIncorporationField;
//            }
//            set
//            {
//                this.dateOfIncorporationField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestPreviousCompanyName PreviousCompanyName
//        {
//            get
//            {
//                return this.previousCompanyNameField;
//            }
//            set
//            {
//                this.previousCompanyNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestAddress Address
//        {
//            get
//            {
//                return this.addressField;
//            }
//            set
//            {
//                this.addressField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCountry Country
//        {
//            get
//            {
//                return this.countryField;
//            }
//            set
//            {
//                this.countryField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCity City
//        {
//            get
//            {
//                return this.cityField;
//            }
//            set
//            {
//                this.cityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestIndustrySector IndustrySector
//        {
//            get
//            {
//                return this.industrySectorField;
//            }
//            set
//            {
//                this.industrySectorField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestTypeOfEntity TypeOfEntity
//        {
//            get
//            {
//                return this.typeOfEntityField;
//            }
//            set
//            {
//                this.typeOfEntityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestOwnershipOfEntity OwnershipOfEntity
//        {
//            get
//            {
//                return this.ownershipOfEntityField;
//            }
//            set
//            {
//                this.ownershipOfEntityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestEntityTypeAndOwnershipDescription EntityTypeAndOwnershipDescription
//        {
//            get
//            {
//                return this.entityTypeAndOwnershipDescriptionField;
//            }
//            set
//            {
//                this.entityTypeAndOwnershipDescriptionField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestPartyType PartyType
//        {
//            get
//            {
//                return this.partyTypeField;
//            }
//            set
//            {
//                this.partyTypeField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestRelationShipEntityToOtherParties RelationShipEntityToOtherParties
//        {
//            get
//            {
//                return this.relationShipEntityToOtherPartiesField;
//            }
//            set
//            {
//                this.relationShipEntityToOtherPartiesField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestRelationShipEntityToEngagement RelationShipEntityToEngagement
//        {
//            get
//            {
//                return this.relationShipEntityToEngagementField;
//            }
//            set
//            {
//                this.relationShipEntityToEngagementField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestOtherInformation OtherInformation
//        {
//            get
//            {
//                return this.otherInformationField;
//            }
//            set
//            {
//                this.otherInformationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestDgmfId
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCompanyName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCountryOfIncorporation
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestDateOfIncorporation
//    {

//        private System.DateTime valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public System.DateTime Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestPreviousCompanyName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestAddress
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCountry
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestCity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestIndustrySector
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestTypeOfEntity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestOwnershipOfEntity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestEntityTypeAndOwnershipDescription
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestPartyType
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestRelationShipEntityToOtherParties
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestRelationShipEntityToEngagement
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoAdditionalPartiesToEngagementCompaniesCompanyRequestOtherInformation
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequest
//    {

//        private OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequestFunctionId functionIdField;

//        private OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequestFunctionLeadUserName functionLeadUserNameField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequestFunctionId FunctionId
//        {
//            get
//            {
//                return this.functionIdField;
//            }
//            set
//            {
//                this.functionIdField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequestFunctionLeadUserName FunctionLeadUserName
//        {
//            get
//            {
//                return this.functionLeadUserNameField;
//            }
//            set
//            {
//                this.functionLeadUserNameField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequestFunctionId
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoOtherParticipatingFunctionRequestFunctionLeadUserName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseEngagementInfoMemberFirmServiceOffering
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfo
//    {

//        private OriginateCaseIn_CaseClientInfoClientDunsNum clientDunsNumField;

//        private OriginateCaseIn_CaseClientInfoTypeOfClient typeOfClientField;

//        private OriginateCaseIn_CaseClientInfoMethodOfObtainingClient methodOfObtainingClientField;

//        private OriginateCaseIn_CaseClientInfoAddressLine1 addressLine1Field;

//        private OriginateCaseIn_CaseClientInfoAddressLine2 addressLine2Field;

//        private OriginateCaseIn_CaseClientInfoCity cityField;

//        private OriginateCaseIn_CaseClientInfoRegion regionField;

//        private OriginateCaseIn_CaseClientInfoPostalCode postalCodeField;

//        private OriginateCaseIn_CaseClientInfoTelephone telephoneField;

//        private OriginateCaseIn_CaseClientInfoFax faxField;

//        private OriginateCaseIn_CaseClientInfoClientUrl clientUrlField;

//        private OriginateCaseIn_CaseClientInfoIndustrySector industrySectorField;

//        private OriginateCaseIn_CaseClientInfoOtherIndustrySector otherIndustrySectorField;

//        private OriginateCaseIn_CaseClientInfoGlcsp glcspField;

//        private OriginateCaseIn_CaseClientInfoBusinessOperation businessOperationField;

//        private OriginateCaseIn_CaseClientInfoFiscalYearEnd fiscalYearEndField;

//        private OriginateCaseIn_CaseClientInfoExternalAuditor externalAuditorField;

//        private OriginateCaseIn_CaseClientInfoOtherAuditor otherAuditorField;

//        private OriginateCaseIn_CaseClientInfoDgmfDescDesignation dgmfDescDesignationField;

//        private OriginateCaseIn_CaseClientInfoDgmfDescRuleSet dgmfDescRuleSetField;

//        private OriginateCaseIn_CaseClientInfoDescDesignation descDesignationField;

//        private OriginateCaseIn_CaseClientInfoDescRuleSet descRuleSetField;

//        private OriginateCaseIn_CaseClientInfoMemberFirmRestricted memberFirmRestrictedField;

//        private OriginateCaseIn_CaseClientInfoDescServiceRequestUsed descServiceRequestUsedField;

//        private OriginateCaseIn_CaseClientInfoDgmfDescDesignationDifference dgmfDescDesignationDifferenceField;

//        private OriginateCaseIn_CaseClientInfoComments commentsField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoClientDunsNum ClientDunsNum
//        {
//            get
//            {
//                return this.clientDunsNumField;
//            }
//            set
//            {
//                this.clientDunsNumField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoTypeOfClient TypeOfClient
//        {
//            get
//            {
//                return this.typeOfClientField;
//            }
//            set
//            {
//                this.typeOfClientField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoMethodOfObtainingClient MethodOfObtainingClient
//        {
//            get
//            {
//                return this.methodOfObtainingClientField;
//            }
//            set
//            {
//                this.methodOfObtainingClientField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoAddressLine1 AddressLine1
//        {
//            get
//            {
//                return this.addressLine1Field;
//            }
//            set
//            {
//                this.addressLine1Field = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoAddressLine2 AddressLine2
//        {
//            get
//            {
//                return this.addressLine2Field;
//            }
//            set
//            {
//                this.addressLine2Field = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoCity City
//        {
//            get
//            {
//                return this.cityField;
//            }
//            set
//            {
//                this.cityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoRegion Region
//        {
//            get
//            {
//                return this.regionField;
//            }
//            set
//            {
//                this.regionField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoPostalCode PostalCode
//        {
//            get
//            {
//                return this.postalCodeField;
//            }
//            set
//            {
//                this.postalCodeField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoTelephone Telephone
//        {
//            get
//            {
//                return this.telephoneField;
//            }
//            set
//            {
//                this.telephoneField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoFax Fax
//        {
//            get
//            {
//                return this.faxField;
//            }
//            set
//            {
//                this.faxField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoClientUrl ClientUrl
//        {
//            get
//            {
//                return this.clientUrlField;
//            }
//            set
//            {
//                this.clientUrlField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoIndustrySector IndustrySector
//        {
//            get
//            {
//                return this.industrySectorField;
//            }
//            set
//            {
//                this.industrySectorField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoOtherIndustrySector OtherIndustrySector
//        {
//            get
//            {
//                return this.otherIndustrySectorField;
//            }
//            set
//            {
//                this.otherIndustrySectorField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoGlcsp Glcsp
//        {
//            get
//            {
//                return this.glcspField;
//            }
//            set
//            {
//                this.glcspField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoBusinessOperation BusinessOperation
//        {
//            get
//            {
//                return this.businessOperationField;
//            }
//            set
//            {
//                this.businessOperationField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoFiscalYearEnd FiscalYearEnd
//        {
//            get
//            {
//                return this.fiscalYearEndField;
//            }
//            set
//            {
//                this.fiscalYearEndField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoExternalAuditor ExternalAuditor
//        {
//            get
//            {
//                return this.externalAuditorField;
//            }
//            set
//            {
//                this.externalAuditorField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoOtherAuditor OtherAuditor
//        {
//            get
//            {
//                return this.otherAuditorField;
//            }
//            set
//            {
//                this.otherAuditorField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoDgmfDescDesignation DgmfDescDesignation
//        {
//            get
//            {
//                return this.dgmfDescDesignationField;
//            }
//            set
//            {
//                this.dgmfDescDesignationField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoDgmfDescRuleSet DgmfDescRuleSet
//        {
//            get
//            {
//                return this.dgmfDescRuleSetField;
//            }
//            set
//            {
//                this.dgmfDescRuleSetField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoDescDesignation DescDesignation
//        {
//            get
//            {
//                return this.descDesignationField;
//            }
//            set
//            {
//                this.descDesignationField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoDescRuleSet DescRuleSet
//        {
//            get
//            {
//                return this.descRuleSetField;
//            }
//            set
//            {
//                this.descRuleSetField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoMemberFirmRestricted MemberFirmRestricted
//        {
//            get
//            {
//                return this.memberFirmRestrictedField;
//            }
//            set
//            {
//                this.memberFirmRestrictedField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoDescServiceRequestUsed DescServiceRequestUsed
//        {
//            get
//            {
//                return this.descServiceRequestUsedField;
//            }
//            set
//            {
//                this.descServiceRequestUsedField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoDgmfDescDesignationDifference DgmfDescDesignationDifference
//        {
//            get
//            {
//                return this.dgmfDescDesignationDifferenceField;
//            }
//            set
//            {
//                this.dgmfDescDesignationDifferenceField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseClientInfoComments Comments
//        {
//            get
//            {
//                return this.commentsField;
//            }
//            set
//            {
//                this.commentsField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoClientDunsNum
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoTypeOfClient
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoMethodOfObtainingClient
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoAddressLine1
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoAddressLine2
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoCity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoRegion
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoPostalCode
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoTelephone
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoFax
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoClientUrl
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoIndustrySector
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoOtherIndustrySector
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoGlcsp
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoBusinessOperation
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoFiscalYearEnd
//    {

//        private System.DateTime valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public System.DateTime Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoExternalAuditor
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoOtherAuditor
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoDgmfDescDesignation
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoDgmfDescRuleSet
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoDescDesignation
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoDescRuleSet
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoMemberFirmRestricted
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoDescServiceRequestUsed
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoDgmfDescDesignationDifference
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseClientInfoComments
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfo
//    {

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersons keyManagementPersonsField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporates affiliatedCorporatesField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersons KeyManagementPersons
//        {
//            get
//            {
//                return this.keyManagementPersonsField;
//            }
//            set
//            {
//                this.keyManagementPersonsField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporates AffiliatedCorporates
//        {
//            get
//            {
//                return this.affiliatedCorporatesField;
//            }
//            set
//            {
//                this.affiliatedCorporatesField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersons
//    {

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequest keyManagementPersonRequestField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequest KeyManagementPersonRequest
//        {
//            get
//            {
//                return this.keyManagementPersonRequestField;
//            }
//            set
//            {
//                this.keyManagementPersonRequestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequest
//    {

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestLastName lastNameField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestFirstName firstNameField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAliasLastName aliasLastNameField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAliasFirstName aliasFirstNameField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestPersonalTitle personalTitleField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestBusinessTitle businessTitleField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestDateOfBirth dateOfBirthField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestGender genderField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCitizenShip citizenShipField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAddress addressField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCountry countryField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCity cityField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestYearsWithEntity yearsWithEntityField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestYearsInPresentPosition yearsInPresentPositionField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestPriorExperience priorExperienceField;

//        private OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestOtherInformation otherInformationField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestLastName LastName
//        {
//            get
//            {
//                return this.lastNameField;
//            }
//            set
//            {
//                this.lastNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestFirstName FirstName
//        {
//            get
//            {
//                return this.firstNameField;
//            }
//            set
//            {
//                this.firstNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAliasLastName AliasLastName
//        {
//            get
//            {
//                return this.aliasLastNameField;
//            }
//            set
//            {
//                this.aliasLastNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAliasFirstName AliasFirstName
//        {
//            get
//            {
//                return this.aliasFirstNameField;
//            }
//            set
//            {
//                this.aliasFirstNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestPersonalTitle PersonalTitle
//        {
//            get
//            {
//                return this.personalTitleField;
//            }
//            set
//            {
//                this.personalTitleField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestBusinessTitle BusinessTitle
//        {
//            get
//            {
//                return this.businessTitleField;
//            }
//            set
//            {
//                this.businessTitleField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestDateOfBirth DateOfBirth
//        {
//            get
//            {
//                return this.dateOfBirthField;
//            }
//            set
//            {
//                this.dateOfBirthField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestGender Gender
//        {
//            get
//            {
//                return this.genderField;
//            }
//            set
//            {
//                this.genderField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCitizenShip CitizenShip
//        {
//            get
//            {
//                return this.citizenShipField;
//            }
//            set
//            {
//                this.citizenShipField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAddress Address
//        {
//            get
//            {
//                return this.addressField;
//            }
//            set
//            {
//                this.addressField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCountry Country
//        {
//            get
//            {
//                return this.countryField;
//            }
//            set
//            {
//                this.countryField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCity City
//        {
//            get
//            {
//                return this.cityField;
//            }
//            set
//            {
//                this.cityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestYearsWithEntity YearsWithEntity
//        {
//            get
//            {
//                return this.yearsWithEntityField;
//            }
//            set
//            {
//                this.yearsWithEntityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestYearsInPresentPosition YearsInPresentPosition
//        {
//            get
//            {
//                return this.yearsInPresentPositionField;
//            }
//            set
//            {
//                this.yearsInPresentPositionField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestPriorExperience PriorExperience
//        {
//            get
//            {
//                return this.priorExperienceField;
//            }
//            set
//            {
//                this.priorExperienceField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestOtherInformation OtherInformation
//        {
//            get
//            {
//                return this.otherInformationField;
//            }
//            set
//            {
//                this.otherInformationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestLastName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestFirstName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAliasLastName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAliasFirstName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestPersonalTitle
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestBusinessTitle
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestDateOfBirth
//    {

//        private System.DateTime valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public System.DateTime Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestGender
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCitizenShip
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestAddress
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCountry
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestCity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestYearsWithEntity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestYearsInPresentPosition
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestPriorExperience
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoKeyManagementPersonsKeyManagementPersonRequestOtherInformation
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporates
//    {

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequest affiliatedCorporateRequestField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequest AffiliatedCorporateRequest
//        {
//            get
//            {
//                return this.affiliatedCorporateRequestField;
//            }
//            set
//            {
//                this.affiliatedCorporateRequestField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequest
//    {

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCompanyName companyNameField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestPreviousCompanyName previousCompanyNameField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestDateOfIncorporation dateOfIncorporationField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCountryOfIncorporation countryOfIncorporationField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestAddress addressField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCountry countryField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCity cityField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestIndustrySector industrySectorField;

//        private OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestOtherInformation otherInformationField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCompanyName CompanyName
//        {
//            get
//            {
//                return this.companyNameField;
//            }
//            set
//            {
//                this.companyNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestPreviousCompanyName PreviousCompanyName
//        {
//            get
//            {
//                return this.previousCompanyNameField;
//            }
//            set
//            {
//                this.previousCompanyNameField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestDateOfIncorporation DateOfIncorporation
//        {
//            get
//            {
//                return this.dateOfIncorporationField;
//            }
//            set
//            {
//                this.dateOfIncorporationField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCountryOfIncorporation CountryOfIncorporation
//        {
//            get
//            {
//                return this.countryOfIncorporationField;
//            }
//            set
//            {
//                this.countryOfIncorporationField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestAddress Address
//        {
//            get
//            {
//                return this.addressField;
//            }
//            set
//            {
//                this.addressField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCountry Country
//        {
//            get
//            {
//                return this.countryField;
//            }
//            set
//            {
//                this.countryField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCity City
//        {
//            get
//            {
//                return this.cityField;
//            }
//            set
//            {
//                this.cityField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestIndustrySector IndustrySector
//        {
//            get
//            {
//                return this.industrySectorField;
//            }
//            set
//            {
//                this.industrySectorField = value;
//            }
//        }

//        /// <remarks/>
//        public OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestOtherInformation OtherInformation
//        {
//            get
//            {
//                return this.otherInformationField;
//            }
//            set
//            {
//                this.otherInformationField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCompanyName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestPreviousCompanyName
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestDateOfIncorporation
//    {

//        private System.DateTime valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public System.DateTime Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCountryOfIncorporation
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestAddress
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCountry
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestCity
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestIndustrySector
//    {

//        private ushort valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public ushort Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseKnowYourClientInfoAffiliatedCorporatesAffiliatedCorporateRequestOtherInformation
//    {

//        private string valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public string Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseConflictCheckInfo
//    {

//        private OriginateCaseIn_CaseConflictCheckInfoInitiateDCCSConflictCheckRequestInDRMS initiateDCCSConflictCheckRequestInDRMSField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseConflictCheckInfoInitiateDCCSConflictCheckRequestInDRMS InitiateDCCSConflictCheckRequestInDRMS
//        {
//            get
//            {
//                return this.initiateDCCSConflictCheckRequestInDRMSField;
//            }
//            set
//            {
//                this.initiateDCCSConflictCheckRequestInDRMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseConflictCheckInfoInitiateDCCSConflictCheckRequestInDRMS
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseIndependenceCheckInfo
//    {

//        private OriginateCaseIn_CaseIndependenceCheckInfoInitiateServiceRequestInDRMS initiateServiceRequestInDRMSField;

//        /// <remarks/>
//        public OriginateCaseIn_CaseIndependenceCheckInfoInitiateServiceRequestInDRMS InitiateServiceRequestInDRMS
//        {
//            get
//            {
//                return this.initiateServiceRequestInDRMSField;
//            }
//            set
//            {
//                this.initiateServiceRequestInDRMSField = value;
//            }
//        }
//    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.deloitte.com/oim/drms/2013/01/25/data")]
//    public partial class OriginateCaseIn_CaseIndependenceCheckInfoInitiateServiceRequestInDRMS
//    {

//        private bool valueField;

//        private bool isProvidedField;

//        /// <remarks/>
//        public bool Value
//        {
//            get
//            {
//                return this.valueField;
//            }
//            set
//            {
//                this.valueField = value;
//            }
//        }

//        /// <remarks/>
//        public bool IsProvided
//        {
//            get
//            {
//                return this.isProvidedField;
//            }
//            set
//            {
//                this.isProvidedField = value;
//            }
//        }
//    }

//}