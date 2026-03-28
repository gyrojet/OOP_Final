using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    [JsonDerivedType(typeof(Minion))]
    [JsonDerivedType(typeof(Elite))]
    [JsonDerivedType(typeof(WorldBoss))]
    public abstract class Creature : IDescribable
    {
        private string _name;
        private string _description;
        private int _level;
        private int _armorClass;

        private int _maxHealth;
        private MonsterType _monsterType;
        private DamageType _resists;

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Level
        { 
            get { return _level; } 
            set 
            {
                if (value >= 1 && value <= 20)
                    _level = value;
            }
        }
        public int AC 
        {  
            get { return _armorClass; }
            set 
            {
                if (value >= 10)
                    _armorClass = value;
                else
                    _armorClass = 10;
            } 
        }
        public int CurrentHealth 
        { 
            get 
            { 
                return _maxHealth; 
            } 
            set 
            { 
                if (value < 0) 
                    _maxHealth = value;
                else
                    _maxHealth = 0;
            } 
        }
        public MonsterType MonsterType { get { return _monsterType; } set { _monsterType = value; } }
        public DamageType Resists { get { return _resists; } set { _resists = value; } }

        public Creature(string inName, string inDesc, int inLevel, MonsterType inType, DamageType inResists)
        {
            Name = inName;
            Description = inDesc;
            MonsterType = inType;
            Level = inLevel;
            Resists = inResists;

            GetACByLevel();
            GetHealthByTypeAndLevel();
            
        }

        public Creature(string inName, string inDesc, int inLevel, int inAC, int inHP, MonsterType inType, DamageType inResists)
        {
            Name = inName;
            Description = inDesc;
            Level = inLevel;
            MonsterType = inType;
            Resists = inResists;

            CurrentHealth = inHP;
            AC = inAC;

        }

        private void GetHealthByTypeAndLevel()
        {
            // Hit dice; used to determine health
            int hd = 0;
            
            // Get die size by type
            switch (MonsterType)
            {
                case MonsterType.Animal:
                case MonsterType.Alien:
                case MonsterType.Humanoid:
                case MonsterType.Ooze:
                    hd = 8;
                    break;

                case MonsterType.Construct: 
                case MonsterType.Dragon:
                    hd = 12;
                    break;

                case MonsterType.Demon:
                case MonsterType.Undead:
                    hd = 10;
                    break;
                // If none of the above: this shouldn't happen
                default:
                    hd = 4;
                    break;
            }

            // Declare a random object
            Random rng = new Random();

            // Generate a hit die of health per level: range 1-HD
            for (int i = 0; i < Level; i++)
            {
                int newHP = rng.Next(1, hd + 1);
                // Add new hp to total
                CurrentHealth += newHP;
            }
        }

        private void GetACByLevel()
        {
            // Ac increases by 1 for every 2 levels, to a max of 20
            _armorClass = 10 + (Level / 2);
        }

        public abstract string Describe();

        //  Display the creature's name
        public override string ToString()
        {
            return $"{Name}";
        }

        
    }
}