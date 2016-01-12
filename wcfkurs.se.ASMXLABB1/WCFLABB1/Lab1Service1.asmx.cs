using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCFLABB1
{
    /// <summary>
    /// Summary description for Lab1Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Lab1Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string EstimatedWeather()
        {

            var numbergenerator = new Random();

            var x = numbergenerator.Next(1, 50);

            if (x <= 10)
                return "It will be sunny! :D";
            else if (x > 10 && x <= 20)
                return "It will be cloudy :(";
            else if (x > 20 && x <= 30)
                return "It will be rainy";
            else
                return "It will be stormy T.T";
        }
    }
}
