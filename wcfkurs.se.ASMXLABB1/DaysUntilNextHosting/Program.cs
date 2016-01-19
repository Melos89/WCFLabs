using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using DaysUntilNextThousandDays;

namespace DaysUntilNextHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("http://localhost:8080/NextThousandDayService");

            using (var host = new ServiceHost(typeof(NextThousandDaysService),baseAdress))
            {
                host.AddServiceEndpoint(typeof(INextThousandDays),new WSHttpBinding(),"NextThousandDaysService");

                var smB = new ServiceMetadataBehavior();
                smB.HttpGetEnabled = true;

                host.Description.Behaviors.Add(smB);

                host.Open();

                Console.WriteLine("Service is now open!");
                Console.WriteLine("To close it press Enter");

                Console.ReadKey();

            }
        }
    }
}
