using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using CharacterGeneratorService;

namespace CharacterGeneratorHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAdress = new Uri("http://localhost:8080/CharacterCreatorService");

            using (var host = new ServiceHost(typeof(CharacterCreatorService),baseAdress))
            {
                host.AddServiceEndpoint(typeof(ICharacterCreator),new WSHttpBinding(),"CharacterCreatorService");

                var smB = new ServiceMetadataBehavior();
                smB.HttpGetEnabled = true;
                 
            }
        }
    }
}
