using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace OOP_BestiaryFinal
{
    public class Minion : Creature
    {
        [JsonConstructor]
        public Minion() { }

        public Minion(string inName, string inDesc, int inLevel, MonsterType inType, DamageType inResists) 
            : base(inName, inDesc, inLevel, inType, inResists) { }

        public Minion(string inName, string inDesc, int inLevel, int inAC, int inHP, MonsterType inType, DamageType inResists)
            : base(inName, inDesc, inLevel, inAC, inHP, inType, inResists) { }

        public override string Describe()
           => $"{Name} (MINION)\n{Description}\n********\nLEVEL: {Level}\n\nHP: {CurrentHealth}\nAC: {AC}\nRESISTS: {Resists}\n\nTYPE: {MonsterType.ToString()}\n********";
    }
}
