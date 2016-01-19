using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCheckerClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide your date of birth in a yyyy/mm/dd format:");

            var result = Console.ReadLine();
            var proxy = new AgeCheckerClient();

            var ageInDays = proxy.AgeInDays(DateTime.Parse(result));
            var ageInHours = proxy.AgeInHours(DateTime.Parse(result));
            var age = proxy.AgeInYears(DateTime.Parse(result));


            Console.WriteLine($"Your age in days: {ageInDays}");
            Console.WriteLine($"Your age in Hours: {ageInHours}");
            Console.WriteLine($"Your age this year: {age}");

            Console.ReadKey();
        }
    }
}
