using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;

namespace WCFLABB1upg5
{
    /// <summary>
    /// Summary description for Lab1Service5
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Lab1Service5 : System.Web.Services.WebService
    {

        [WebMethod]
        public string DateFinder(string name)
        {
            var dict = listPopulator();
            var day = dict.Where(x => x.Value.Contains(name)).Select(x => x.Key).ToString();
            return day;
        }
        public Dictionary<string,string> listPopulator()
        {
            var dict = new Dictionary<string, string>();
            var textLine = "";
            using (var stream = new StreamReader("/~Namnsdag.txt"))
            {
                while ((textLine = stream.ReadLine()) != null)
                {
                    var rows = textLine.Split(',');
                    dict.Add(rows[0], rows[1]);
                }
            }
                return dict;
        }
    }
}
