using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Runtime.Serialization;


namespace AgeCheckerService
{
    [ServiceContract(Namespace ="http://AgeCheckerService")]
    public interface IAgeChecker
    {
        [OperationContract]
        double AgeInYears(DateTime date);
        [OperationContract]
        double AgeInDays(DateTime date);
        [OperationContract]
        double AgeInHours(DateTime date);
    }
    public class AgeCheckerService : IAgeChecker
    {
        public double AgeInDays(DateTime date)
        {
            var now = DateTime.Now;
            var resultAge = now - date;
            return resultAge.TotalDays;
        }

        public double AgeInHours(DateTime date)
        {
            var now = DateTime.Now;
            var resultAge = now - date;
            return resultAge.TotalHours;
        }

        public double AgeInYears(DateTime date)
        {
            var now = DateTime.Now;
            var resultAge = now.Year - date.Year;
            return resultAge;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("http://localhost:8080/AgeCheckerService");

            using (var host = new ServiceHost(typeof(AgeCheckerService),baseAdress))
            {
                host.AddServiceEndpoint(typeof(IAgeChecker),new WSHttpBinding(),"AgeCheckerService");

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
