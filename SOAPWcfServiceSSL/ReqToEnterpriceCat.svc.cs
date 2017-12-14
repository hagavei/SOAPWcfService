using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace SOAPWcfService2
{

    public class Constants
    {
        // Ensures consistency in the namespace declarations across services
        public const string Namespace = "http://www.mil.fobid.test.no";
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    // public class Service1 : IService2
    [ServiceBehavior(Namespace = Constants.Namespace)]
    public class ReqToEnterpriceCat : IReqToEnterpriceCat
    {
        public void ReceiveFobidRequestToFile(FobidMsg fobidmsg)
        {
            StreamWriter file = new System.IO.StreamWriter(@"c:\temp\logfileReceiveFobidRequest.txt", true);
            file.WriteLine("Activity on webservice with ReceiveFobidRequest: " + System.DateTime.Now.ToString());
            try
            {
                file.WriteLine("fobidmsg.MsgId: " + fobidmsg.MsgId.ToString());
            }
            catch (Exception e)
            {
                System.IO.StreamWriter file2 = new System.IO.StreamWriter(@"c:\temp\logfileReceiveFobidRequestErr.txt", true);
                file2.WriteLine("Activity on webservice with ReceiveFobidRequest: " + System.DateTime.Now.ToString());
                file2.WriteLine("...MsgId.ToString() error with ReceiveFobidRequest: " + e.ToString());
                file2.Close();
            }

            file.WriteLine("------------------------");
            file.Close();
        }


        public FobidMsgResp ReceiveFobidRequestWithResp(FobidMsg fobidmsg)
        {
            StreamWriter file = new System.IO.StreamWriter(@"c:\temp\logfileReceiveFobidRequestWithResp.txt", true);
            file.WriteLine("Activity on webservice with ReceiveFobidRequestWithResp: " + System.DateTime.Now.ToString());
            try
            {
                
            }
            catch (Exception e)
            {
                System.IO.StreamWriter file2 = new System.IO.StreamWriter(@"c:\temp\logfileReceiveFobidRequestWithRespErr.txt", true);
                file2.WriteLine("Activity on webservice with ReceiveFobidRequestWithResp: " + System.DateTime.Now.ToString());
                file2.WriteLine("...MsgId.ToString() error with ReceiveFobidRequestWithResp: " + e.ToString());
                file2.Close();
            }

            file.WriteLine("------------------------");
            file.Close();

            FobidMsgResp fobidResponse = new FobidMsgResp();
            fobidResponse.retval = "Receiced id was: " + fobidmsg.MsgId;

            return fobidResponse;
        }


    }
    
}
