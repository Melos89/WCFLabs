using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICounterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide your height in cm:");
            var height = Console.ReadLine();
            Console.WriteLine("Now provide your weight:");
            var weight = Console.ReadLine();

            var proxy = new BMICounterClient();

            var bmi = proxy.CalculateBMI(float.Parse(weight),float.Parse(height));

            Console.WriteLine("Your calculated bmi: " + bmi);

            Console.ReadKey();
        }
    }
}
