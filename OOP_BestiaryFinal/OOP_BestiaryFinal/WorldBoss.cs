using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    public sealed class WorldBoss : Creature
    {
        public List<Ability> AbilityList { get; set; }

        public WorldBoss(string inName, string inDesc, int inLevel, List<Ability> inAbility, MonsterType inType)
            : base(inName, inDesc, inLevel, inType)
        {
            AbilityList = inAbility;
        }

        public WorldBoss(string inName, string inDesc, int inLevel, List<Ability> inAbility, int inAC, int inHP, MonsterType inType)
            : base(inName, inDesc, inLevel, inAC, inHP, inType)
        {
            AbilityList = inAbility;
        }

        public override string Describe()
            => $"{Name} (WORLD BOSS!)\n{Description}\n********\nLEVEL: {Level}\n\nHP: {CurrentHealth}\nAC: {AC}\n\nTYPE: {MonsterType.ToString()}\n********";
    }
}
