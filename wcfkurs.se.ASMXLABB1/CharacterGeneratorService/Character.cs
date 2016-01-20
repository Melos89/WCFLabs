using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CharacterGeneratorService
{
    [DataContract(Namespace =("http://CharacterGeneratorService"))]
    public class Character
    {
        public Character(string name, string classType, int age)
        {
            Name = name;
            ClassType = classType;
            Age = age;
            Level = 1;
            Abilities = new List<string>();
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ClassType { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public double Health { get; set; }
        [DataMember]
        public int Level { get; set; }
        [DataMember]
        public List<string> Abilities { get; set; }
    }
}
