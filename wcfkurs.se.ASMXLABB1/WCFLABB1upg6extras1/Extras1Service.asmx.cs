using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCFLABB1upg6extras1
{
    /// <summary>
    /// Summary description for Extras1Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Extras1Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string FindMovies(string year)
        {
            var dict = ListPopulator(year);
            return "Hello World";
        }

        private Dictionary<string,string> ListPopulator(string year)
        {
            //To get the location the assembly normally resides on disk or the install directory
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            //once you have the path you get the directory with:
            var directory = Path.GetDirectoryName(path);
            //Cut away unwanted start sequence:
            var dir = directory.Substring(6);

            var dict = new Dictionary<string, string>();
            var textLine = "";
            using (var stream = new StreamReader(dir + "\\StopMotionMovies.txt"))
            {
                while ((textLine = stream.ReadLine()) != null)
                {
                    var rows = textLine.Split('.');
                    dict.Add(rows[0], rows[1]);
                }
            }
            return dict;
        }
    }
}
