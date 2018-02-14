using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService1
{
    /// <summary>
    /// Summary description for AddOperation
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddOperation : System.Web.Services.WebService
    {
        public secured SoapHeader;

        [WebMethod]
        [System.Web.Services.Protocols.SoapHeader("SoapHeader")]
        public float Add (float FirstNumber,float SecondNumber)
        {
            
            return FirstNumber + SecondNumber;
        }
    }
}
