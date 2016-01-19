using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using AgeService;

namespace AgeCheckerHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("http://localhost:8080/AgeCheckerService");

            using (var host = new ServiceHost(typeof(AgeCheckerService), baseAdress))
            {
                host.AddServiceEndpoint(typeof(IAgeChecker), new WSHttpBinding(), "AgeCheckerService");

                var smB = new ServiceMetadataBehavior();
                smB.HttpGetEnabled = true;

                host.Description.Behaviors.Add(smB);

                host.Open();
                Console.WriteLine("Service is now open!");
                Console.WriteLine("To shut service down press Enter");
                Console.ReadKey();
            }
        }
    }
}
