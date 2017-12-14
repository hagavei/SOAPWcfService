
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


namespace SOAPWcfService2
{
    [ServiceContract(Namespace = Constants.Namespace)]
    public interface IReqToEnterpriceCat
    {
        [OperationContract, XmlSerializerFormat]
        void ReceiveFobidRequestToFile(FobidMsg fobidmsg);

        [OperationContract, XmlSerializerFormat]
        FobidMsgResp ReceiveFobidRequestWithResp(FobidMsg fobidmsg);
    }



    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mil.fobid.test.no")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.mil.fobid.test.no", IsNullable = false)]
    [DataContract]
    public class FobidMsg
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

    }


    [DataContract]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mil.fobid.test.no")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.mil.fobid.test.no", IsNullable = false)]
    public class FobidMsgResp
    {
        private string retvalField;

        [DataMember]
        public string retval
        {
            get { return this.retvalField; }
            set { this.retvalField = value; }
        }
    }

    /* ***************************** */

}
