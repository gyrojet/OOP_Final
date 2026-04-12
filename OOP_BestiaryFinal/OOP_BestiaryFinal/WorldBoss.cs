using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    // A class representing the world boss, the most powerful of all monsters!
    public sealed class WorldBoss : Creature
    {
        // A list of abilities possessed by the monster
        private List<Ability> _abilities = new List<Ability>();

        // Get/set ability list: count may never be below 1
        public List<Ability> AbilityList { get { return _abilities; } set { if (value.Count > 0) _abilities = value; } }

        // Constructor used to deserialize json object
        [JsonConstructor]
        public WorldBoss() { }

        // Constructor with random hp/ac
        public WorldBoss(string inName, string inDesc, int inLevel, List<Ability> inAbility, Classification inClass, MonsterType inType, DamageType inResists, bool inRand)
            : base(inName, inDesc, inLevel, inClass, inType, inResists, inRand)
        {
            AbilityList = inAbility;
        }

        // Constructor with fixed hp/ac
        public WorldBoss(string inName, string inDesc, int inLevel, List<Ability> inAbility, int inAC, int inHP, Classification inClass, MonsterType inType, DamageType inResists, bool inRand)
            : base(inName, inDesc, inLevel, inAC, inHP, inClass, inType, inResists, inRand)
        {
            AbilityList = inAbility;
        }

        // Return a formated description
        public override string Describe()
            => $"{Name} (WORLD BOSS!)\n{Description}\n********\nLEVEL: {Level}\n\nHP: {CurrentHealth}\nAC: {AC}\nRESISTS: {Resists}\n\nTYPE: {MonsterType.ToString()}\n********";

        // Overloaded operator: Add an ability to the ability list
        public static WorldBoss operator +(WorldBoss boss, Ability ability)
        {
            // Add ability to boss' list, then return it
            boss.AbilityList.Add(ability);
            return boss;
        }
    }
}
