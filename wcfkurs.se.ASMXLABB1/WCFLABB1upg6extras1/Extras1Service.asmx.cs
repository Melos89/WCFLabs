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

            var result = "";

            var movies = dict.Where(x => x.Key.Contains(year)).Select(x => x.Value).FirstOrDefault();
            if (movies != null)
            {
                foreach (var movie in movies)
                {
                    result += movie + "\n\r";
                }
                result = result.Trim();
                return result;
            }
            else
                return "No movies found";
        }

        private Dictionary<string,List<string>> ListPopulator(string year)
        {
            //To get the location the assembly normally resides on disk or the install directory
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            //once you have the path you get the directory with:
            var directory = Path.GetDirectoryName(path);
            //Cut away unwanted start sequence:
            var dir = directory.Substring(6);

            var dict = new Dictionary<string, List<string>>();
            var textLine = "";
            using (var stream = new StreamReader(dir + "\\StopMotionMovies.txt"))
            {
                while ((textLine = stream.ReadLine()) != null)
                {
                    var rows = textLine.Split('.');

                    if (!dict.Keys.Contains(rows[0]))
                        dict.Add(rows[0], new List<string> { rows[1] });
                    else
                        dict[rows[0]].Add(rows[1]);

                }
            }
            return dict;
        }
    }
}
