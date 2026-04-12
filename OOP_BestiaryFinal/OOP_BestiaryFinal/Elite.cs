using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    // Class representing an elite monster with an ability
    public class Elite : Creature
    {
        // Stores ability
        public Ability Ability { get; set; }

        // Used for json de-serialization
        [JsonConstructor]
        public Elite() { }
        
        // Constructor with random values
        public Elite(string inName, string inDesc, int inLevel, Ability inAbility, Classification inClass, MonsterType inType, DamageType inResists, bool inRand)
            : base(inName, inDesc, inLevel, inClass, inType, inResists, inRand)
        {
            Ability = inAbility;
        }

        // Constructor with fixed values
        public Elite(string inName, string inDesc, int inLevel, Ability inAbility, int inAC, int inHP, Classification inClass, MonsterType inType, DamageType inResists, bool inRand)
            : base(inName, inDesc, inLevel, inAC, inHP, inClass, inType, inResists, inRand)
        {
            Ability = inAbility;
        }

        // Prints detailed description of monster with specific info
        public override string Describe()
           => $"{Name} (ELITE)\n{Description}\n********\nLEVEL: {Level}\n\nHP: {CurrentHealth}\nAC: {AC}\nRESISTS: {Resists}\n\nTYPE: {MonsterType.ToString()}\n********";
    }
}
