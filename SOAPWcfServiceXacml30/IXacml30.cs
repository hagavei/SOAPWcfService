﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SOAPWcfServiceXacml30
{
    /* ***************************** */
    /* SERVICE                       */
    /* ***************************** */


    [ServiceContract(Namespace = Constants.nsConst)]
    public interface IXacml30
    {
        [OperationContract, XmlSerializerFormat]
        void EmptyRequest(String str);

        [OperationContract, XmlSerializerFormat]
        void EmptyRequest2(String str);

        [OperationContract, XmlSerializerFormat]
        void EmptyRequest3(String str);

        //[OperationContract]
        //ResponseMessage ReceiveXcaml30Test(RequestMessage Request);

        [OperationContract]
        ResponseMessageWithWrapper ReceiveXcaml30TestNW(RequestMessageNoWrapper Request);
    }


    /* ***************************** */
    /* REQUEST                       */
    /* ***************************** */

    #region requestMessageContract
    [MessageContract(IsWrapped = true, WrapperName = "Xacml30Request", WrapperNamespace = Constants.nsConst)]
    public class RequestMessage
    {
        [MessageBodyMember(Namespace = Constants.nsConst)]
        public Request myRequest;
    }
    #endregion

    #region requestMessageContractNoWrapper
    [MessageContract(IsWrapped = false)]
    public class RequestMessageNoWrapper
    {
        [MessageBodyMember(Namespace = Constants.nsConst)]
        public Request myRequest;
    }
    #endregion

    #region requestDataContract
    //[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = Constants.nsConst)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = Constants.nsConst, IsNullable = false)]
    [DataContract]
    public class Request
    {

        private Attributes AttributesField;

        public Attributes Attributes
        {
            get
            {
                return this.AttributesField;
            }
            set
            {
                this.AttributesField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = Constants.nsConst)]
    public class Attributes
    {
        private Attribute AttributeField;

        public Attribute Attribute
        {
            get
            {
                return this.AttributeField;
            }
            set
            {
                this.AttributeField = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = Constants.nsConst)]

    public class Attribute
    {
        private string AttributeValueField;

        public string AttributeValue
        {
            get
            {
                return this.AttributeValueField;
            }
            set
            {
                this.AttributeValueField = value;
            }
        }
    }
    #endregion


    /* ***************************** */
    /* RESPONSE                      */
    /* ***************************** */

    #region responseMessageContract
    [MessageContract(IsWrapped = false)]
    public class ResponseMessage
    {
        [MessageBodyMember(Namespace = Constants.nsConst)]
        public Response Response;

    }
    #endregion

    #region responseMessageWithWrapperContract
    [MessageContract(IsWrapped = true, WrapperName ="Response", WrapperNamespace = Constants.nsConst)]
    public class ResponseMessageWithWrapper
    {
        [MessageBodyMember(Namespace = Constants.nsConst)]
        public Result Result;

    }
    #endregion

    #region responseDataContract
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "")]
    [DataContract(Namespace = "")]
    public class Response
    {
        private Result ResultField;

        [DataMember]
        public Result Result
        {
            get
            {
                return this.ResultField;
            }
            set
            {
                this.ResultField = value;
            }
        }
    }

    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = Constants.nsConst)]
    [DataContract(Namespace = Constants.nsConst)]
    public class Result
    {
        private string DecisionField;

        [DataMember]
        public string Decision
        {
            get
            {
                return this.DecisionField;
            }
            set
            {
                this.DecisionField = value;
            }
        }
    }

    #endregion


    /* ***************************** */
    #region RequestAndReponseOrgSchema
        
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]

    [DataContract]
    public class RequestX
    {
        private RequestType RequestTypeField;

        [DataMember]
        public RequestType RequestType
        {
            get
            {
                return this.RequestTypeField;
            }
            set
            {
                this.RequestTypeField = value;
            }
        }
    }

    // [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Request", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    [DataContract]
    public class RequestType
    {
        private RequestDefaultsType requestDefaultsField;
        private AttributesType[] attributesField;
        private AttributesReferenceType[][] multiRequestsField;
        private bool returnPolicyIdListField;
        private bool combinedDecisionField;

        /// <remarks/>
        public RequestDefaultsType RequestDefaults
        {
            get
            {
                return this.requestDefaultsField;
            }
            set
            {
                this.requestDefaultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attributes")]
        public AttributesType[] Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RequestReference", IsNullable = false)]
        [System.Xml.Serialization.XmlArrayItemAttribute("AttributesReference", IsNullable = false, NestingLevel = 1)]
        public AttributesReferenceType[][] MultiRequests
        {
            get
            {
                return this.multiRequestsField;
            }
            set
            {
                this.multiRequestsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ReturnPolicyIdList
        {
            get
            {
                return this.returnPolicyIdListField;
            }
            set
            {
                this.returnPolicyIdListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool CombinedDecision
        {
            get
            {
                return this.combinedDecisionField;
            }
            set
            {
                this.combinedDecisionField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Response", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    [DataContract]
    public class ResponseType
    {
        private ResultType[] resultField;

        [System.Xml.Serialization.XmlElementAttribute("Result")]
        public ResultType[] Result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Result", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public class ResultType
    {
        private DecisionType decisionField;
        private StatusType statusField;
        private ObligationType[] obligationsField;
        private AdviceType[] associatedAdviceField;
        private AttributesType[] attributesField;
        private PolicyIdentifierListType policyIdentifierListField;

        public DecisionType Decision
        {
            get
            {
                return this.decisionField;
            }
            set
            {
                this.decisionField = value;
            }
        }

        public StatusType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Obligation", IsNullable = false)]
        public ObligationType[] Obligations
        {
            get
            {
                return this.obligationsField;
            }
            set
            {
                this.obligationsField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("Advice", IsNullable = false)]
        public AdviceType[] AssociatedAdvice
        {
            get
            {
                return this.associatedAdviceField;
            }
            set
            {
                this.associatedAdviceField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("Attributes")]
        public AttributesType[] Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }

        public PolicyIdentifierListType PolicyIdentifierList
        {
            get
            {
                return this.policyIdentifierListField;
            }
            set
            {
                this.policyIdentifierListField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("RequestDefaults", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class RequestDefaultsType
    {

        private string itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPathVersion", DataType = "anyURI")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }


    /// <remarks/>
    /*
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FunctionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeValueType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeAssignmentType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeDesignatorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeSelectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VariableReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    public abstract partial class ExpressionType
    {

    }
    */

    /// <remarks/>
    // [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplyType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(FunctionType))]
    // [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeValueType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeAssignmentType))]
    //[System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeDesignatorType))]
    // [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeSelectorType))]
    // [System.Xml.Serialization.XmlIncludeAttribute(typeof(VariableReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    // public abstract partial class ExpressionType
    public partial class ExpressionType
    {
        private string[] textField;

        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Attributes", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AttributesType
    {

        private System.Xml.XmlNode contentField;

        private AttributeType[] attributeField;

        private string categoryField;

        private string idField;

        /// <remarks/>
        public System.Xml.XmlNode Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public AttributeType[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Attribute", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AttributeType
    {

        private AttributeValueType[] attributeValueField;

        private string attributeIdField;

        private string issuerField;

        private bool includeInResultField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeValue")]
        public AttributeValueType[] AttributeValue
        {
            get
            {
                return this.attributeValueField;
            }
            set
            {
                this.attributeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string AttributeId
        {
            get
            {
                return this.attributeIdField;
            }
            set
            {
                this.attributeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IncludeInResult
        {
            get
            {
                return this.includeInResultField;
            }
            set
            {
                this.includeInResultField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeAssignmentType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AttributeValue", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AttributeValueType : ExpressionType
    {

        private System.Xml.XmlNode[] anyField;

        private string dataTypeField;

        private System.Xml.XmlAttribute[] anyAttrField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr
        {
            get
            {
                return this.anyAttrField;
            }
            set
            {
                this.anyAttrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AttributesReference", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AttributesReferenceType
    {

        private string referenceIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string ReferenceId
        {
            get
            {
                return this.referenceIdField;
            }
            set
            {
                this.referenceIdField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Decision", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public enum DecisionType
    {

        /// <remarks/>
        Permit,

        /// <remarks/>
        Deny,

        /// <remarks/>
        Indeterminate,

        /// <remarks/>
        NotApplicable,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Status", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class StatusType
    {

        private StatusCodeType statusCodeField;

        private string statusMessageField;

        private StatusDetailType statusDetailField;

        /// <remarks/>
        public StatusCodeType StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        public string StatusMessage
        {
            get
            {
                return this.statusMessageField;
            }
            set
            {
                this.statusMessageField = value;
            }
        }

        /// <remarks/>
        public StatusDetailType StatusDetail
        {
            get
            {
                return this.statusDetailField;
            }
            set
            {
                this.statusDetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("StatusCode", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class StatusCodeType
    {

        private StatusCodeType statusCodeField;

        private string valueField;

        /// <remarks/>
        public StatusCodeType StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("StatusDetail", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class StatusDetailType
    {

        private System.Xml.XmlElement[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Obligation", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class ObligationType
    {

        private AttributeAssignmentType[] attributeAssignmentField;

        private string obligationIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeAssignment")]
        public AttributeAssignmentType[] AttributeAssignment
        {
            get
            {
                return this.attributeAssignmentField;
            }
            set
            {
                this.attributeAssignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string ObligationId
        {
            get
            {
                return this.obligationIdField;
            }
            set
            {
                this.obligationIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AttributeAssignment", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AttributeAssignmentType : AttributeValueType
    {

        private string attributeIdField;

        private string categoryField;

        private string issuerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string AttributeId
        {
            get
            {
                return this.attributeIdField;
            }
            set
            {
                this.attributeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Advice", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AdviceType
    {

        private AttributeAssignmentType[] attributeAssignmentField;

        private string adviceIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeAssignment")]
        public AttributeAssignmentType[] AttributeAssignment
        {
            get
            {
                return this.attributeAssignmentField;
            }
            set
            {
                this.attributeAssignmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string AdviceId
        {
            get
            {
                return this.adviceIdField;
            }
            set
            {
                this.adviceIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("PolicyIdentifierList", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class PolicyIdentifierListType
    {

        private IdReferenceType[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PolicyIdReference", typeof(IdReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("PolicySetIdReference", typeof(IdReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public IdReferenceType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("PolicySetIdReference", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class IdReferenceType
    {

        private string versionField;

        private string earliestVersionField;

        private string latestVersionField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EarliestVersion
        {
            get
            {
                return this.earliestVersionField;
            }
            set
            {
                this.earliestVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LatestVersion
        {
            get
            {
                return this.latestVersionField;
            }
            set
            {
                this.latestVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType = "anyURI")]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        PolicyIdReference,

        /// <remarks/>
        PolicySetIdReference,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("MissingAttributeDetail", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class MissingAttributeDetailType
    {

        private AttributeValueType[] attributeValueField;

        private string categoryField;

        private string attributeIdField;

        private string dataTypeField;

        private string issuerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeValue")]
        public AttributeValueType[] AttributeValue
        {
            get
            {
                return this.attributeValueField;
            }
            set
            {
                this.attributeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string AttributeId
        {
            get
            {
                return this.attributeIdField;
            }
            set
            {
                this.attributeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("MultiRequests", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class MultiRequestsType
    {

        private AttributesReferenceType[][] requestReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AttributesReference", typeof(AttributesReferenceType), IsNullable = false)]
        public AttributesReferenceType[][] RequestReference
        {
            get
            {
                return this.requestReferenceField;
            }
            set
            {
                this.requestReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("RequestReference", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class RequestReferenceType
    {

        private AttributesReferenceType[] attributesReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributesReference")]
        public AttributesReferenceType[] AttributesReference
        {
            get
            {
                return this.attributesReferenceField;
            }
            set
            {
                this.attributesReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Obligations", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class ObligationsType
    {

        private ObligationType[] obligationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Obligation")]
        public ObligationType[] Obligation
        {
            get
            {
                return this.obligationField;
            }
            set
            {
                this.obligationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AssociatedAdvice", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AssociatedAdviceType
    {

        private AdviceType[] adviceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Advice")]
        public AdviceType[] Advice
        {
            get
            {
                return this.adviceField;
            }
            set
            {
                this.adviceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("ObligationExpressions", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class ObligationExpressionsType
    {

        private ObligationExpressionType[] obligationExpressionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObligationExpression")]
        public ObligationExpressionType[] ObligationExpression
        {
            get
            {
                return this.obligationExpressionField;
            }
            set
            {
                this.obligationExpressionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("ObligationExpression", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class ObligationExpressionType
    {

        private AttributeAssignmentExpressionType[] attributeAssignmentExpressionField;

        private string obligationIdField;

        private EffectType fulfillOnField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeAssignmentExpression")]
        public AttributeAssignmentExpressionType[] AttributeAssignmentExpression
        {
            get
            {
                return this.attributeAssignmentExpressionField;
            }
            set
            {
                this.attributeAssignmentExpressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string ObligationId
        {
            get
            {
                return this.obligationIdField;
            }
            set
            {
                this.obligationIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EffectType FulfillOn
        {
            get
            {
                return this.fulfillOnField;
            }
            set
            {
                this.fulfillOnField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AttributeAssignmentExpression", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AttributeAssignmentExpressionType
    {

        private ExpressionType itemField;

        private string attributeIdField;

        private string categoryField;

        private string issuerField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Apply", typeof(ApplyType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeDesignator", typeof(AttributeDesignatorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeValue", typeof(AttributeValueType))]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("VariableReference", typeof(VariableReferenceType))]
        public ExpressionType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string AttributeId
        {
            get
            {
                return this.attributeIdField;
            }
            set
            {
                this.attributeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Apply", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class ApplyType : ExpressionType
    {

        private string descriptionField;

        private ExpressionType[] itemsField;

        private string functionIdField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Apply", typeof(ApplyType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeDesignator", typeof(AttributeDesignatorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeValue", typeof(AttributeValueType))]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("VariableReference", typeof(VariableReferenceType))]
        public ExpressionType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string FunctionId
        {
            get
            {
                return this.functionIdField;
            }
            set
            {
                this.functionIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AttributeDesignator", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AttributeDesignatorType : ExpressionType
    {

        private string categoryField;

        private string attributeIdField;

        private string dataTypeField;

        private string issuerField;

        private bool mustBePresentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string AttributeId
        {
            get
            {
                return this.attributeIdField;
            }
            set
            {
                this.attributeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MustBePresent
        {
            get
            {
                return this.mustBePresentField;
            }
            set
            {
                this.mustBePresentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AttributeSelector", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AttributeSelectorType : ExpressionType
    {

        private string categoryField;

        private string contextSelectorIdField;

        private string pathField;

        private string dataTypeField;

        private bool mustBePresentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string ContextSelectorId
        {
            get
            {
                return this.contextSelectorIdField;
            }
            set
            {
                this.contextSelectorIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MustBePresent
        {
            get
            {
                return this.mustBePresentField;
            }
            set
            {
                this.mustBePresentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Function", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class FunctionType : ExpressionType
    {

        private string functionIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string FunctionId
        {
            get
            {
                return this.functionIdField;
            }
            set
            {
                this.functionIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("VariableReference", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class VariableReferenceType : ExpressionType
    {

        private string variableIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VariableId
        {
            get
            {
                return this.variableIdField;
            }
            set
            {
                this.variableIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    public enum EffectType
    {

        /// <remarks/>
        Permit,

        /// <remarks/>
        Deny,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AdviceExpressions", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AdviceExpressionsType
    {

        private AdviceExpressionType[] adviceExpressionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdviceExpression")]
        public AdviceExpressionType[] AdviceExpression
        {
            get
            {
                return this.adviceExpressionField;
            }
            set
            {
                this.adviceExpressionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AdviceExpression", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AdviceExpressionType
    {

        private AttributeAssignmentExpressionType[] attributeAssignmentExpressionField;

        private string adviceIdField;

        private EffectType appliesToField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeAssignmentExpression")]
        public AttributeAssignmentExpressionType[] AttributeAssignmentExpression
        {
            get
            {
                return this.attributeAssignmentExpressionField;
            }
            set
            {
                this.attributeAssignmentExpressionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string AdviceId
        {
            get
            {
                return this.adviceIdField;
            }
            set
            {
                this.adviceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EffectType AppliesTo
        {
            get
            {
                return this.appliesToField;
            }
            set
            {
                this.appliesToField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("PolicySet", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class PolicySetType
    {

        private string descriptionField;

        private PolicyIssuerType policyIssuerField;

        private DefaultsType policySetDefaultsField;

        private TargetType targetField;

        private object[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private ObligationExpressionType[] obligationExpressionsField;

        private AdviceExpressionType[] adviceExpressionsField;

        private string policySetIdField;

        private string versionField;

        private string policyCombiningAlgIdField;

        private string maxDelegationDepthField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public PolicyIssuerType PolicyIssuer
        {
            get
            {
                return this.policyIssuerField;
            }
            set
            {
                this.policyIssuerField = value;
            }
        }

        /// <remarks/>
        public DefaultsType PolicySetDefaults
        {
            get
            {
                return this.policySetDefaultsField;
            }
            set
            {
                this.policySetDefaultsField = value;
            }
        }

        /// <remarks/>
        public TargetType Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CombinerParameters", typeof(CombinerParametersType))]
        [System.Xml.Serialization.XmlElementAttribute("Policy", typeof(PolicyType))]
        [System.Xml.Serialization.XmlElementAttribute("PolicyCombinerParameters", typeof(PolicyCombinerParametersType))]
        [System.Xml.Serialization.XmlElementAttribute("PolicyIdReference", typeof(IdReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("PolicySet", typeof(PolicySetType))]
        [System.Xml.Serialization.XmlElementAttribute("PolicySetCombinerParameters", typeof(PolicySetCombinerParametersType))]
        [System.Xml.Serialization.XmlElementAttribute("PolicySetIdReference", typeof(IdReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObligationExpression", IsNullable = false)]
        public ObligationExpressionType[] ObligationExpressions
        {
            get
            {
                return this.obligationExpressionsField;
            }
            set
            {
                this.obligationExpressionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AdviceExpression", IsNullable = false)]
        public AdviceExpressionType[] AdviceExpressions
        {
            get
            {
                return this.adviceExpressionsField;
            }
            set
            {
                this.adviceExpressionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string PolicySetId
        {
            get
            {
                return this.policySetIdField;
            }
            set
            {
                this.policySetIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string PolicyCombiningAlgId
        {
            get
            {
                return this.policyCombiningAlgIdField;
            }
            set
            {
                this.policyCombiningAlgIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxDelegationDepth
        {
            get
            {
                return this.maxDelegationDepthField;
            }
            set
            {
                this.maxDelegationDepthField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("PolicyIssuer", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class PolicyIssuerType
    {

        private System.Xml.XmlNode contentField;

        private AttributeType[] attributeField;

        /// <remarks/>
        public System.Xml.XmlNode Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public AttributeType[] Attribute
        {
            get
            {
                return this.attributeField;
            }
            set
            {
                this.attributeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("PolicySetDefaults", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class DefaultsType
    {

        private string itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPathVersion", DataType = "anyURI")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Target", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class TargetType
    {

        private AnyOfType[] anyOfField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnyOf")]
        public AnyOfType[] AnyOf
        {
            get
            {
                return this.anyOfField;
            }
            set
            {
                this.anyOfField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AnyOf", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AnyOfType
    {

        private AllOfType[] allOfField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllOf")]
        public AllOfType[] AllOf
        {
            get
            {
                return this.allOfField;
            }
            set
            {
                this.allOfField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("AllOf", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class AllOfType
    {

        private MatchType[] matchField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Match")]
        public MatchType[] Match
        {
            get
            {
                return this.matchField;
            }
            set
            {
                this.matchField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Match", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class MatchType
    {

        private AttributeValueType attributeValueField;

        private ExpressionType itemField;

        private string matchIdField;

        /// <remarks/>
        public AttributeValueType AttributeValue
        {
            get
            {
                return this.attributeValueField;
            }
            set
            {
                this.attributeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeDesignator", typeof(AttributeDesignatorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
        public ExpressionType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string MatchId
        {
            get
            {
                return this.matchIdField;
            }
            set
            {
                this.matchIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolicySetCombinerParametersType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolicyCombinerParametersType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RuleCombinerParametersType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("CombinerParameters", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class CombinerParametersType
    {

        private CombinerParameterType[] combinerParameterField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CombinerParameter")]
        public CombinerParameterType[] CombinerParameter
        {
            get
            {
                return this.combinerParameterField;
            }
            set
            {
                this.combinerParameterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("CombinerParameter", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class CombinerParameterType
    {

        private AttributeValueType attributeValueField;

        private string parameterNameField;

        /// <remarks/>
        public AttributeValueType AttributeValue
        {
            get
            {
                return this.attributeValueField;
            }
            set
            {
                this.attributeValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParameterName
        {
            get
            {
                return this.parameterNameField;
            }
            set
            {
                this.parameterNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Policy", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class PolicyType
    {

        private string descriptionField;

        private PolicyIssuerType policyIssuerField;

        private DefaultsType policyDefaultsField;

        private TargetType targetField;

        private object[] itemsField;

        private ObligationExpressionType[] obligationExpressionsField;

        private AdviceExpressionType[] adviceExpressionsField;

        private string policyIdField;

        private string versionField;

        private string ruleCombiningAlgIdField;

        private string maxDelegationDepthField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public PolicyIssuerType PolicyIssuer
        {
            get
            {
                return this.policyIssuerField;
            }
            set
            {
                this.policyIssuerField = value;
            }
        }

        /// <remarks/>
        public DefaultsType PolicyDefaults
        {
            get
            {
                return this.policyDefaultsField;
            }
            set
            {
                this.policyDefaultsField = value;
            }
        }

        /// <remarks/>
        public TargetType Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CombinerParameters", typeof(CombinerParametersType))]
        [System.Xml.Serialization.XmlElementAttribute("Rule", typeof(RuleType))]
        [System.Xml.Serialization.XmlElementAttribute("RuleCombinerParameters", typeof(RuleCombinerParametersType))]
        [System.Xml.Serialization.XmlElementAttribute("VariableDefinition", typeof(VariableDefinitionType))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObligationExpression", IsNullable = false)]
        public ObligationExpressionType[] ObligationExpressions
        {
            get
            {
                return this.obligationExpressionsField;
            }
            set
            {
                this.obligationExpressionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AdviceExpression", IsNullable = false)]
        public AdviceExpressionType[] AdviceExpressions
        {
            get
            {
                return this.adviceExpressionsField;
            }
            set
            {
                this.adviceExpressionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string PolicyId
        {
            get
            {
                return this.policyIdField;
            }
            set
            {
                this.policyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string RuleCombiningAlgId
        {
            get
            {
                return this.ruleCombiningAlgIdField;
            }
            set
            {
                this.ruleCombiningAlgIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string MaxDelegationDepth
        {
            get
            {
                return this.maxDelegationDepthField;
            }
            set
            {
                this.maxDelegationDepthField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Rule", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class RuleType
    {

        private string descriptionField;

        private TargetType targetField;

        private ConditionType conditionField;

        private ObligationExpressionType[] obligationExpressionsField;

        private AdviceExpressionType[] adviceExpressionsField;

        private string ruleIdField;

        private EffectType effectField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public TargetType Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        public ConditionType Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObligationExpression", IsNullable = false)]
        public ObligationExpressionType[] ObligationExpressions
        {
            get
            {
                return this.obligationExpressionsField;
            }
            set
            {
                this.obligationExpressionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AdviceExpression", IsNullable = false)]
        public AdviceExpressionType[] AdviceExpressions
        {
            get
            {
                return this.adviceExpressionsField;
            }
            set
            {
                this.adviceExpressionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleId
        {
            get
            {
                return this.ruleIdField;
            }
            set
            {
                this.ruleIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EffectType Effect
        {
            get
            {
                return this.effectField;
            }
            set
            {
                this.effectField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("Condition", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class ConditionType
    {

        private ExpressionType itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Apply", typeof(ApplyType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeDesignator", typeof(AttributeDesignatorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeValue", typeof(AttributeValueType))]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("VariableReference", typeof(VariableReferenceType))]
        public ExpressionType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("RuleCombinerParameters", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class RuleCombinerParametersType : CombinerParametersType
    {

        private string ruleIdRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RuleIdRef
        {
            get
            {
                return this.ruleIdRefField;
            }
            set
            {
                this.ruleIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("VariableDefinition", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class VariableDefinitionType
    {

        private ExpressionType itemField;

        private string variableIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Apply", typeof(ApplyType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeDesignator", typeof(AttributeDesignatorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeValue", typeof(AttributeValueType))]
        [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
        [System.Xml.Serialization.XmlElementAttribute("VariableReference", typeof(VariableReferenceType))]
        public ExpressionType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VariableId
        {
            get
            {
                return this.variableIdField;
            }
            set
            {
                this.variableIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("PolicyCombinerParameters", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class PolicyCombinerParametersType : CombinerParametersType
    {

        private string policyIdRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string PolicyIdRef
        {
            get
            {
                return this.policyIdRefField;
            }
            set
            {
                this.policyIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17")]
    [System.Xml.Serialization.XmlRootAttribute("PolicySetCombinerParameters", Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IsNullable = false)]
    public partial class PolicySetCombinerParametersType : CombinerParametersType
    {

        private string policySetIdRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string PolicySetIdRef
        {
            get
            {
                return this.policySetIdRefField;
            }
            set
            {
                this.policySetIdRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        CombinerParameters,

        /// <remarks/>
        Policy,

        /// <remarks/>
        PolicyCombinerParameters,

        /// <remarks/>
        PolicyIdReference,

        /// <remarks/>
        PolicySet,

        /// <remarks/>
        PolicySetCombinerParameters,

        /// <remarks/>
        PolicySetIdReference,
    }

    #endregion


}
