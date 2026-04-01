using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    public class Elite : Creature
    {
        public Ability Ability { get; set; }

        [JsonConstructor]
        public Elite() { }

        public Elite(string inName, string inDesc, int inLevel, Ability inAbility, Classification inClass, MonsterType inType, DamageType inResists)
            : base(inName, inDesc, inLevel, inClass, inType, inResists)
        {
            Ability = inAbility;
        }

        public Elite(string inName, string inDesc, int inLevel, Ability inAbility, int inAC, int inHP, Classification inClass, MonsterType inType, DamageType inResists)
            : base(inName, inDesc, inLevel, inAC, inHP, inClass, inType, inResists)
        {
            Ability = inAbility;
        }

        public override string Describe()
           => $"{Name} (ELITE)\n{Description}\n********\nLEVEL: {Level}\n\nHP: {CurrentHealth}\nAC: {AC}\nRESISTS: {Resists}\n\nTYPE: {MonsterType.ToString()}\n********";
    }
}
