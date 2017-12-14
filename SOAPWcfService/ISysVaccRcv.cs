using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Runtime.Remoting;
using System.Xml;
using System.Xml.Serialization;


namespace SOAPWcfService
{
    [ServiceContract(Namespace = Constants.nsConst)]
    public interface ISysVaccRcv
    {

        [OperationContract, XmlSerializerFormat]
        void ReceiveVaccineRequest(MsgHead MsgHead);

        [OperationContract, XmlSerializerFormat]
        void ReceiveVaccineRequestTest(MsgHead2 MsgHead);         

    }

    /* ***************************** */
    /* MsgHead2 (simpleversion)      */
    /* ***************************** */

    #region MsgHead2DataContract
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24", IsNullable = false)]
    [DataContract]
    public class MsgHead2
    {
        private string MsgIdField;

        [DataMember]
        public string MsgId
        {
            get
            {
                return this.MsgIdField;
            }
            set
            {
                this.MsgIdField = value;
            }
        }

        private MsgHeadDocumentRefDocContentSokRequest2 MsgHeadDocumentRefDocContentSokRequest2Field2;

        public MsgHeadDocumentRefDocContentSokRequest2 MsgHeadDocumentRefDocContentSokRequest2
        {
            get
            {
                return this.MsgHeadDocumentRefDocContentSokRequest2Field2;
            }
            set
            {
                this.MsgHeadDocumentRefDocContentSokRequest2Field2 = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/sysvak/sokrequest/2008-01-01")]
    public class MsgHeadDocumentRefDocContentSokRequest2
    {
        private MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhet2 utfortAvHelseenhetField2;

        public MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhet2 UtfortAvHelseenhet2
        {
            get
            {
                return this.utfortAvHelseenhetField2;
            }
            set
            {
                this.utfortAvHelseenhetField2 = value;
            }
        }

    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/felleskomponent1")]
    public class MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhet2
    {
        private uint idField;

        public uint Id
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
    #endregion





   

    /* ***************************** */
    /* MsgHead                       */
    /* ***************************** */

    #region msgheadDataContract

    [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24", IsNullable = false)]
        [DataContract]
        public partial class MsgHead
        {

            private MsgHeadMsgInfo msgInfoField;

            private MsgHeadDocument documentField;


            public MsgHeadMsgInfo MsgInfo
            {
                get
                {
                    return this.msgInfoField;
                }
                set
                {
                    this.msgInfoField = value;
                }
            }


            public MsgHeadDocument Document
            {
                get
                {
                    return this.documentField;
                }
                set
                {
                    this.documentField = value;
                }
            }
        }


        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfo
        {

            private MsgHeadMsgInfoType typeField;

            private string mIGversionField;

            private System.DateTime genDateField;

            private string msgIdField;

            private MsgHeadMsgInfoSender senderField;

            private MsgHeadMsgInfoReceiver receiverField;


            public MsgHeadMsgInfoType Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }


            public string MIGversion
            {
                get
                {
                    return this.mIGversionField;
                }
                set
                {
                    this.mIGversionField = value;
                }
            }


            public System.DateTime GenDate
            {
                get
                {
                    return this.genDateField;
                }
                set
                {
                    this.genDateField = value;
                }
            }


            public string MsgId
            {
                get
                {
                    return this.msgIdField;
                }
                set
                {
                    this.msgIdField = value;
                }
            }


            public MsgHeadMsgInfoSender Sender
            {
                get
                {
                    return this.senderField;
                }
                set
                {
                    this.senderField = value;
                }
            }


            public MsgHeadMsgInfoReceiver Receiver
            {
                get
                {
                    return this.receiverField;
                }
                set
                {
                    this.receiverField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoType
        {

            private string vField;

            private string dnField;


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string V
            {
                get
                {
                    return this.vField;
                }
                set
                {
                    this.vField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DN
            {
                get
                {
                    return this.dnField;
                }
                set
                {
                    this.dnField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoSender
        {

            private MsgHeadMsgInfoSenderOrganisation organisationField;


            public MsgHeadMsgInfoSenderOrganisation Organisation
            {
                get
                {
                    return this.organisationField;
                }
                set
                {
                    this.organisationField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoSenderOrganisation
        {

            private string organisationNameField;

            private MsgHeadMsgInfoSenderOrganisationIdent identField;

            private MsgHeadMsgInfoSenderOrganisationAddress addressField;


            public string OrganisationName
            {
                get
                {
                    return this.organisationNameField;
                }
                set
                {
                    this.organisationNameField = value;
                }
            }


            public MsgHeadMsgInfoSenderOrganisationIdent Ident
            {
                get
                {
                    return this.identField;
                }
                set
                {
                    this.identField = value;
                }
            }


            public MsgHeadMsgInfoSenderOrganisationAddress Address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoSenderOrganisationIdent
        {

            private ushort idField;

            private MsgHeadMsgInfoSenderOrganisationIdentTypeId typeIdField;


            public ushort Id
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


            public MsgHeadMsgInfoSenderOrganisationIdentTypeId TypeId
            {
                get
                {
                    return this.typeIdField;
                }
                set
                {
                    this.typeIdField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoSenderOrganisationIdentTypeId
        {

            private string vField;

            private string sField;

            private string dnField;


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string V
            {
                get
                {
                    return this.vField;
                }
                set
                {
                    this.vField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string S
            {
                get
                {
                    return this.sField;
                }
                set
                {
                    this.sField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DN
            {
                get
                {
                    return this.dnField;
                }
                set
                {
                    this.dnField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoSenderOrganisationAddress
        {

            private MsgHeadMsgInfoSenderOrganisationAddressType typeField;

            private string streetAdrField;

            private ushort postalCodeField;

            private string cityField;


            public MsgHeadMsgInfoSenderOrganisationAddressType Type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }


            public string StreetAdr
            {
                get
                {
                    return this.streetAdrField;
                }
                set
                {
                    this.streetAdrField = value;
                }
            }


            public ushort PostalCode
            {
                get
                {
                    return this.postalCodeField;
                }
                set
                {
                    this.postalCodeField = value;
                }
            }


            public string City
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoSenderOrganisationAddressType
        {

            private string vField;

            private string dnField;


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string V
            {
                get
                {
                    return this.vField;
                }
                set
                {
                    this.vField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DN
            {
                get
                {
                    return this.dnField;
                }
                set
                {
                    this.dnField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoReceiver
        {

            private MsgHeadMsgInfoReceiverOrganisation organisationField;


            public MsgHeadMsgInfoReceiverOrganisation Organisation
            {
                get
                {
                    return this.organisationField;
                }
                set
                {
                    this.organisationField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoReceiverOrganisation
        {

            private string organisationNameField;

            private MsgHeadMsgInfoReceiverOrganisationIdent identField;


            public string OrganisationName
            {
                get
                {
                    return this.organisationNameField;
                }
                set
                {
                    this.organisationNameField = value;
                }
            }


            public MsgHeadMsgInfoReceiverOrganisationIdent Ident
            {
                get
                {
                    return this.identField;
                }
                set
                {
                    this.identField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoReceiverOrganisationIdent
        {

            private uint idField;

            private MsgHeadMsgInfoReceiverOrganisationIdentTypeId typeIdField;


            public uint Id
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


            public MsgHeadMsgInfoReceiverOrganisationIdentTypeId TypeId
            {
                get
                {
                    return this.typeIdField;
                }
                set
                {
                    this.typeIdField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadMsgInfoReceiverOrganisationIdentTypeId
        {

            private string vField;

            private string sField;

            private string dnField;


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string V
            {
                get
                {
                    return this.vField;
                }
                set
                {
                    this.vField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string S
            {
                get
                {
                    return this.sField;
                }
                set
                {
                    this.sField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DN
            {
                get
                {
                    return this.dnField;
                }
                set
                {
                    this.dnField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadDocument
        {

            private MsgHeadDocumentRefDoc refDocField;


            public MsgHeadDocumentRefDoc RefDoc
            {
                get
                {
                    return this.refDocField;
                }
                set
                {
                    this.refDocField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadDocumentRefDoc
        {

            private MsgHeadDocumentRefDocMsgType msgTypeField;

            private MsgHeadDocumentRefDocContent contentField;


            public MsgHeadDocumentRefDocMsgType MsgType
            {
                get
                {
                    return this.msgTypeField;
                }
                set
                {
                    this.msgTypeField = value;
                }
            }


            public MsgHeadDocumentRefDocContent Content
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
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24")]
        public partial class MsgHeadDocumentRefDocMsgType
        {

            private string vField;

            private string dnField;


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string V
            {
                get
                {
                    return this.vField;
                }
                set
                {
                    this.vField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DN
            {
                get
                {
                    return this.dnField;
                }
                set
                {
                    this.dnField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/sysvak/sokrequest/2008-01-01")]
        public partial class MsgHeadDocumentRefDocContent
        {

            private MsgHeadDocumentRefDocContentSokRequest sokRequestField;


            public MsgHeadDocumentRefDocContentSokRequest SokRequest
            {
                get
                {
                    return this.sokRequestField;
                }
                set
                {
                    this.sokRequestField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/sysvak/sokrequest/2008-01-01")]
        public partial class MsgHeadDocumentRefDocContentSokRequest
        {

            private MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhet utfortAvHelseenhetField;

            private MsgHeadDocumentRefDocContentSokRequestIdent identField;


            public MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhet UtfortAvHelseenhet
            {
                get
                {
                    return this.utfortAvHelseenhetField;
                }
                set
                {
                    this.utfortAvHelseenhetField = value;
                }
            }


            public MsgHeadDocumentRefDocContentSokRequestIdent Ident
            {
                get
                {
                    return this.identField;
                }
                set
                {
                    this.identField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/felleskomponent1")]
        public partial class MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhet
        {

            private uint idField;

            private MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhetTypeId typeIdField;


            public uint Id
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


            public MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhetTypeId TypeId
            {
                get
                {
                    return this.typeIdField;
                }
                set
                {
                    this.typeIdField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/felleskomponent1")]
        public partial class MsgHeadDocumentRefDocContentSokRequestUtfortAvHelseenhetTypeId
        {

            private string vField;

            private string sField;

            private string dnField;


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string V
            {
                get
                {
                    return this.vField;
                }
                set
                {
                    this.vField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string S
            {
                get
                {
                    return this.sField;
                }
                set
                {
                    this.sField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DN
            {
                get
                {
                    return this.dnField;
                }
                set
                {
                    this.dnField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/felleskomponent1")]
        public partial class MsgHeadDocumentRefDocContentSokRequestIdent
        {

            private uint idField;

            private MsgHeadDocumentRefDocContentSokRequestIdentTypeId typeIdField;


            public uint Id
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


            public MsgHeadDocumentRefDocContentSokRequestIdentTypeId TypeId
            {
                get
                {
                    return this.typeIdField;
                }
                set
                {
                    this.typeIdField = value;
                }
            }
        }


        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.kith.no/xmlstds/felleskomponent1")]
        public partial class MsgHeadDocumentRefDocContentSokRequestIdentTypeId
        {

            private string vField;

            private string sField;

            private string dnField;


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string V
            {
                get
                {
                    return this.vField;
                }
                set
                {
                    this.vField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string S
            {
                get
                {
                    return this.sField;
                }
                set
                {
                    this.sField = value;
                }
            }


            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string DN
            {
                get
                {
                    return this.dnField;
                }
                set
                {
                    this.dnField = value;
                }
            }


        }
             
    #endregion
}
