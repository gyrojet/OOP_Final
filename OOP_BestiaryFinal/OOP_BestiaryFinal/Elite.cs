using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    public class Elite : Creature
    {
        public Ability Ability { get; set; }

        public Elite(string inName, string inDesc, int inLevel, Ability inAbility, MonsterType inType)
            : base(inName, inDesc, inLevel, inType)
        {
            Ability = inAbility;
        }

        public Elite(string inName, string inDesc, int inLevel, Ability inAbility, int inAC, int inHP, MonsterType inType)
            : base(inName, inDesc, inLevel, inAC, inHP, inType)
        {
            Ability = inAbility;
        }

        public override string Describe()
            => $"**ELITE**\n{Description}";
    }
}
