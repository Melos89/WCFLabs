using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CharacterGeneratorService
{
    [KnownType(typeof(Character))]
    public class CharacterCreatorService : ICharacterCreator
    {
        public Character GenerateCharacter(string name, string classType, int age)
        {
            return new Character(name,classType,age);
        }
    }
}
