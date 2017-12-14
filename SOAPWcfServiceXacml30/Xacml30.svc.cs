using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace SOAPWcfServiceXacml30
{
    public class Constants
    {
        //
        // Ensures consistency in the namespace declarations across services
        public const string Namespace = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17";
        public const string nsConst = "urn:oasis:names:tc:xacml:3.0:core:schema:wd-17";
        // public const string nsConst20 = "urn:oasis:names:tc:xacml:2.0:context:schema:os";
    }

    public class Xacml30 : IXacml30
    {
        /*
        public ResponseMessage ReceiveXcaml30Test(RequestMessage Request)
        {
            ResponseMessage responsemessage = new ResponseMessage();
            Response response = new Response();
            Result result = new Result();

            responsemessage.Response = response;
            responsemessage.Response.Result = result;
            responsemessage.Response.Result.Decision = "Permit";


            try
            {
                StreamWriter file1 = new System.IO.StreamWriter(@"c:\temp\logfileReceiveXcaml30Test" + System.DateTime.Now.ToString() + ".txt");
                file1.WriteLine("Activity on webservice with ReceiveXcaml30Test: " + System.DateTime.Now.ToString());
                file1.WriteLine("Request: " + "dummy".ToString());
                file1.WriteLine("------------------------");
                file1.Close();
            }
            catch (Exception e)
            {
                System.IO.StreamWriter file12 = new System.IO.StreamWriter(@"c:\temp\logfileReceiveXcaml30TestErr.txt" + System.DateTime.Now.ToString() + ".txt");
                file12.WriteLine("Activity on webservice with Request: " + System.DateTime.Now.ToString());
                file12.WriteLine("...Request.ToString() error with Request: " + e.ToString());
                file12.Close();
            }

            return responsemessage;
        }

    */

        public ResponseMessageWithWrapper ReceiveXcaml30TestNW(RequestMessageNoWrapper Request)
        {
            ResponseMessageWithWrapper responsemessage = new ResponseMessageWithWrapper();
            Result result = new Result();

            responsemessage.Result = result;
            responsemessage.Result.Decision = "Permit";


            try
            {
                StreamWriter file1 = new System.IO.StreamWriter(@"c:\temp\logfileReceiveXcaml30TestNW" + System.DateTime.Now.ToString() + ".txt");
                file1.WriteLine("Activity on webservice with ReceiveXcaml30TestNW: " + System.DateTime.Now.ToString());
                file1.WriteLine("Request: " + "dummy".ToString());
                file1.WriteLine("------------------------");
                file1.Close();
            }
            catch (Exception e)
            {
                System.IO.StreamWriter file12 = new System.IO.StreamWriter(@"c:\temp\logfileReceiveXcaml30TestErrNW.txt" + System.DateTime.Now.ToString() + ".txt");
                file12.WriteLine("Activity on webservice with RequestNW: " + System.DateTime.Now.ToString());
                file12.WriteLine("...Request.ToString() error with RequestNW: " + e.ToString());
                file12.Close();
            }

            return responsemessage;
        }




        public void EmptyRequest(String str)
        {

        }
    }
}
