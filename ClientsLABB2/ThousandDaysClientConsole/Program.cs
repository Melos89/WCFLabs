using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThousandDaysClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var proxy = new NextThousandDaysClient();

            Console.WriteLine("Provide your date of birth in a yyyy/mm/dd format:");

            var date = Console.ReadLine();

            var result = proxy.DaysToGo(DateTime.Parse(date));


            Console.WriteLine($"next time you have an even thousand days to your age is: {result.ToString()}");
            Console.ReadKey();
        }
    }
}
