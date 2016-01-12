using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCFLABB1upg3
{
    /// <summary>
    /// Summary description for Lab1Service3
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Lab1Service3 : System.Web.Services.WebService
    {

        [WebMethod]
        public int AddThreeNumbers(int nr1,int nr2,int nr3)
        {
            return nr1+nr2+nr3;
        }
    }
}
