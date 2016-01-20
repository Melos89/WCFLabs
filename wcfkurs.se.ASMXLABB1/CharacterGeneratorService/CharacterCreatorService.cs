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
        public double CalculateHealth(int age,int level)
        {
            if (age < 60)
                return age * (1.25 + level);
            else 
                return age * (0.50 + level);
        }

        public List<string> GenerateAblities(string classType)
        {
            var Abilities = new List<string>();
            switch (classType)
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
            return Abilities;
        }

        public Character GenerateCharacter(string name, string classType, int age)
        {
            return new Character(name,classType,age);
        }
    }
}
