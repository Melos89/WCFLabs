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
            var query = (from d in dict
                       where d.Value.Contains(name)
                       select d.Key).FirstOrDefault();
            if (query != null)
                return query.ToString();
            else
                return "Not in the list!";
        }
        public Dictionary<string,string> listPopulator()
        {
            //To get the location the assembly normally resides on disk or the install directory
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            //once you have the path you get the directory with:
            var directory = Path.GetDirectoryName(path);
            //Cut away unwanted start sequence:
            var dir = directory.Substring(6);

            var dict = new Dictionary<string, string>();
            var textLine = "";
            using (var stream = new StreamReader(dir + "\\Namnsdag.txt"))
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
