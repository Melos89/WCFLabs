using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace BMIService
{
    [ServiceContract(Namespace ="http://BMIService")]
    public interface IBMICounter
    {
        [OperationContract]
        float CalculateBMI(float weight,float height);
    }
    public class BMICounterService : IBMICounter
    {
        public float CalculateBMI(float weightinKilos, float heightinCentimetres)
        {
            return (weightinKilos / heightinCentimetres) * weightinKilos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("http://localhost:8080/BMIService");

            using (var host = new ServiceHost(typeof(BMICounterService),baseAdress))
            {
                host.AddServiceEndpoint(typeof(IBMICounter),new WSHttpBinding(),"BMICounterService");

                var smB = new ServiceMetadataBehavior();
                smB.HttpGetEnabled = true;

                host.Description.Behaviors.Add(smB);

                host.Open();
                Console.WriteLine("Service is open for business!");
                Console.WriteLine("Press Enter to kill the service");
                Console.ReadKey();
            }
        }
    }
}
