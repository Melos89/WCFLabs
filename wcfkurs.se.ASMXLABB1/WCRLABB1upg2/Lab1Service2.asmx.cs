using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCRLABB1upg2
{
    /// <summary>
    /// Summary description for Lab1Service2
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Lab1Service2 : System.Web.Services.WebService
    {

        [WebMethod]
        public int AddFunction(int nrx,int nry)
        {
            return nrx + nry;
        }
    }
}
