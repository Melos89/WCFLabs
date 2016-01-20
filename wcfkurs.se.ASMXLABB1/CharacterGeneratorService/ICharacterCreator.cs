using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace CharacterGeneratorService
{
    [ServiceContract(Namespace ="http://CharacterGeneratorService")]
    public interface ICharacterCreator
    {
        [OperationContract]
        Character GenerateCharacter(string name, string classType, int age);
    }
}
