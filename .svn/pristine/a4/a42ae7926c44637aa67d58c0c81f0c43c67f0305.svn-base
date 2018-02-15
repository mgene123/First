using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService1
{
    public class secured :System.Web.Services.Protocols.SoapHeader
    {
        public string username { get; set; }
        public string password { get; set; }
        public string authenticationtoken { get; set;}

        public bool Isvalid(string user,string pass)
        {
            if (user == "admin" && pass == "admin")
                return true;
            else
                return false;
        }
    public bool Isvalid (secured SoapHeader)
        {
            if (SoapHeader == null)
                return false;
            if (!string.IsNullOrEmpty(SoapHeader.authenticationtoken))
                return (HttpRuntime.Cache[SoapHeader.authenticationtoken] != null);

                    return false;
        }
    }
}