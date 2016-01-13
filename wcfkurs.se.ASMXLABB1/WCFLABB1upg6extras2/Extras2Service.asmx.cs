using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WCFLABB1upg6extras2
{
    /// <summary>
    /// Summary description for Extras2Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Extras2Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string FruitFinder(char letterKey)
        {
            char letter = char.ToUpper(letterKey);
            var list = FruitPopulator();
            var result = "";
            if (list.Keys.Contains(letter))
            {
                foreach (var fruit in list[letter])
                {
                    result += fruit + "\r\n" + "----------------";
                }
                return result;
            }
            else
                return "No fruit was found!";
        }

        private Dictionary<char,List<string>> FruitPopulator()
        {
            //To get the location the assembly normally resides on disk or the install directory
            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            //once you have the path you get the directory with:
            var directory = Path.GetDirectoryName(path);
            //Cut away unwanted start sequence:
            var dir = directory.Substring(6);

            var dict = new Dictionary<char, List<string>>();
            var textLine = "";
            using (var stream = new StreamReader(dir + "\\Fruits.txt"))
            {
                while ((textLine = stream.ReadLine()) != null)
                {
                    var letter = textLine.ElementAt(0);

                    if (!dict.Keys.Contains(letter))
                        dict.Add(letter, new List<string> { textLine});
                    else
                        dict[letter].Add(textLine);

                }
            }
            return dict;
        }
    }
}
