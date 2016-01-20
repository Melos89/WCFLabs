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
            AbilityGenerator();
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
        [OperationContract]
        public void LevelUp()
        {
            Level++;
            ResilienceCalculator();
        }
        
        private void ResilienceCalculator()
        {
            if (Age < 60)
                Health = Age * (1.25 + Level);
            if (Age >= 60)
                Health = Age * (0.50 + Level);

        }
        private void AbilityGenerator()
        {
            switch (ClassType)
            {
                case "Mage":
                    Abilities.Add("Firebolt");
                    Abilities.Add("Icebolt");
                    Abilities.Add("Arcane knowledge");
                    break;
                case "Warrior":
                    Abilities.Add("Cleave");
                    Abilities.Add("Raging blow");
                    Abilities.Add("Berserker");
                    break;
                case "Rogue":
                    Abilities.Add("Lockpick");
                    Abilities.Add("Backstab");
                    Abilities.Add("Lightfooted");
                    break;
                case "Paladin":
                    Abilities.Add("Cleansing Prayer");
                    Abilities.Add("Judgement");
                    Abilities.Add("Stalwart Defender");
                    break;
                case "Shaman":
                    Abilities.Add("Earth spike");
                    Abilities.Add("Rejuvenation");
                    Abilities.Add("Attuned to nature");
                    break;
                default:
                    
                    break;
            }
        }
    }
}
