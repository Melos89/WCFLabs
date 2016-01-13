using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace WCFLABB1upg6extras3
{
    /// <summary>
    /// Summary description for Extras3Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Extras3Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string FindDeadPeopleByMonth(string Month)
        {
            var list = DeadPeoplePopulator();
            var result = "";
            if (list.Keys.Contains(Month))
            {
                foreach (var person in list[Month])
                {
                    result += person + "\r\n" + "----------------";
                }
                return result;
            }
            else
                return "Someone probably died somewhere we just can´t find them!";
        }

        private Dictionary<string,List<string>> DeadPeoplePopulator()
        {
            //To get the location the assembly normally resides on disk or the install directory
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            //once you have the path you get the directory with:
            var directory = Path.GetDirectoryName(path);
            //Cut away unwanted start sequence:
            var dir = directory.Substring(6);

            var dict = new Dictionary<string, List<string>>();
            var textLine = "";


            using (var stream = new StreamReader(dir + "\\DeadPeople.txt"))
            {
                while ((textLine = stream.ReadLine()) != null)
                {
                    var letter = textLine.Split('.');
                    var key = Regex.Replace(letter[0], @"[\d-]", string.Empty);

                    if (!dict.Keys.Contains(key))
                        dict.Add(key, new List<string> { textLine});
                    else
                        dict[key].Add(textLine);

                }
            }
            return dict;
        }
    }
}
