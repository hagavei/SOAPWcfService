using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace SOAPWcfService
{

    public class Constants
    {
        // Ensures consistency in the namespace declarations across services
        public const string Namespace = "http://www.kith.no/xmlstds/msghead/2006-05-24";
        public const string nsConst = "http://www.kith.no/xmlstds/msghead/2006-05-24";

    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    // public class Service1 : IService2


    // [ServiceBehavior(Namespace = Constants.Namespace)]
    [ServiceBehavior(Namespace = Constants.nsConst)]
    public class SysVaccRcv : ISysVaccRcv
    {
        
        public void ReceiveVaccineRequest(MsgHead MsgHead)
        {
            StreamWriter file = new System.IO.StreamWriter(@"c:\temp\logfileReceiveVaccineRequestTest.txt", true);
            file.WriteLine("Activity on webservice with ReceiveVaccineRequestTest: " + System.DateTime.Now.ToString());
            try
            {
                file.WriteLine("MsgHead.MsgInfo.MsgId: " + MsgHead.MsgInfo.MsgId.ToString());
                file.WriteLine("MsgHead.Document.RefDoc.Content.SokRequest.UAHIdent.Id: " + MsgHead.Document.RefDoc.Content.SokRequest.UtfortAvHelseenhet.Id.ToString());
                file.WriteLine("MsgHead.Document.RefDoc.Content.SokRequest.Ident.Id: " + MsgHead.Document.RefDoc.Content.SokRequest.Ident.Id.ToString());
            }
            catch (Exception e)
            {
                System.IO.StreamWriter file2 = new System.IO.StreamWriter(@"c:\temp\logfileReceiveVaccineRequestTestErr.txt", true);
                file2.WriteLine("Activity on webservice with ReceiveVaccineRequestTest: " + System.DateTime.Now.ToString());
                file2.WriteLine("...MsgId.ToString() error with ReceiveVaccineRequestTest: " + e.ToString());
                file2.Close();
            }

            file.WriteLine("------------------------");
            file.Close();
        }


        // 
        public void ReceiveVaccineRequestTest(MsgHead2 MsgHead)
        {
            StreamWriter file = new System.IO.StreamWriter(@"c:\temp\logfileReceiveVaccineRequestTest.txt", true);
            file.WriteLine("Activity on webservice with ReceiveVaccineRequestTest2: " + System.DateTime.Now.ToString());
            try
            {
                file.WriteLine(MsgHead.MsgId.ToString());
            }
            catch (Exception e)
            {
                System.IO.StreamWriter file2 = new System.IO.StreamWriter(@"c:\temp\logfileReceiveVaccineRequestTestErr.txt", true);
                file2.WriteLine("Activity on webservice with ReceiveVaccineRequestTest:2 " + System.DateTime.Now.ToString());
                file2.WriteLine("...MsgId.ToString() error with ReceiveVaccineRequestTest2: " + e.ToString());
                file2.Close();
            }

            file.WriteLine("------------------------");
            file.Close();
        }
        
    }
    
}
