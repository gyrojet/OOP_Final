using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    public sealed class WorldBoss : Creature
    {
        private List<Ability> _abilities;

        public List<Ability> AbilityList { get { return _abilities; } set { if (value.Count > 0) _abilities = value; } }

        [JsonConstructor]
        public WorldBoss() { }

        public WorldBoss(string inName, string inDesc, int inLevel, List<Ability> inAbility, MonsterType inType, DamageType inResists)
            : base(inName, inDesc, inLevel, inType, inResists)
        {
            AbilityList = inAbility;
        }

        public WorldBoss(string inName, string inDesc, int inLevel, List<Ability> inAbility, int inAC, int inHP, MonsterType inType, DamageType inResists)
            : base(inName, inDesc, inLevel, inAC, inHP, inType, inResists)
        {
            AbilityList = inAbility;
        }

        public override string Describe()
            => $"{Name} (WORLD BOSS!)\n{Description}\n********\nLEVEL: {Level}\n\nHP: {CurrentHealth}\nAC: {AC}\nRESISTS: {Resists}\n\nTYPE: {MonsterType.ToString()}\n********";
    }
}
