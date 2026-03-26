using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOP_BestiaryFinal
{
    public class Minion : Creature
    {
        public Minion(string inName, string inDesc, int inLevel, MonsterType inType) 
            : base(inName, inDesc, inLevel, inType) { }

        public Minion(string inName, string inDesc, int inLevel, int inAC, int inHP, MonsterType inType)
            : base(inName, inDesc, inLevel, inAC, inHP, inType) { }

        public override string Describe()
            => $"**MINION**\n{Description}";
    }
}
