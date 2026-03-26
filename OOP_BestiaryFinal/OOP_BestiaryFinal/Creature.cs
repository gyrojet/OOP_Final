using System;
using System.Collections.Generic;
using System.Linq;
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
        [JsonInclude] private string _name;
        [JsonInclude] private string _description;
        [JsonInclude] private int _level;
        [JsonInclude] private int _armorClass;

        [JsonInclude] private int _maxHealth;
        [JsonInclude] private MonsterType _monsterType;

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public int Level
        { 
            get { return _level; } 
            set 
            {
                if (value >= 1 && value <= 20)
                    _level = value;
            }
        }
        public int AC {  get { return _armorClass; } }
        public int CurrentHealth { get; set; }
        public MonsterType MonsterType { get { return _monsterType; } }

        public Creature(string inName, string inDesc, int inLevel, MonsterType inType)
        {
            _name = inName;
            _description = inDesc;
            _monsterType = inType;
            Level = inLevel;

            GetACByLevel();
            GetHealthByTypeAndLevel();

            CurrentHealth = _maxHealth;

            // Call get functions here
        }

        public Creature(string inName, string inDesc, int inLevel, int inAC, int inHP, MonsterType inType)
        {
            _name = inName;
            _description = inDesc;
            Level = inLevel;
            _monsterType = inType;

            _maxHealth = inHP;
            _armorClass = inAC;

            CurrentHealth = _maxHealth;
        }

        private void GetHealthByTypeAndLevel()
        {
            int hd = 0;
            
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

                default:
                    hd = 8;
                    break;
            }

            Random rng = new Random();

            for (int i = 0; i < Level; i++)
            {
                int newHP = rng.Next(1, hd + 1);
                _maxHealth += newHP;
            }
        }

        private void GetACByLevel()
        {
            _armorClass = 10 + (Level / 2);
        }

        public abstract string Describe();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}