using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    public abstract class Creature : IDescribable
    {
        private string _name;
        private string _description;
        private int _level;
        private int _armorClass;

        private int _maxHealth;
        private MonsterType _monsterType;


        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public int Level { get { return _level; } }
        public int AC {  get { return _armorClass; } }
        public int CurrentHealth { get; set; }
        public MonsterType MonsterType { get { return _monsterType; } }

        public Creature(string inName, string inDesc, int inLevel, MonsterType inType)
        {
            _name = inName;
            _description = inDesc;
            _level = inLevel;
            _monsterType = inType;

            _maxHealth = 0;
            _armorClass = 0;

            CurrentHealth = _maxHealth;

            // Call get functions here
        }

        public Creature(string inName, string inDesc, int inLevel, int inAC, int inHP, MonsterType inType)
        {
            _name = inName;
            _description = inDesc;
            _level = inLevel;
            _monsterType = inType;

            _maxHealth = inHP;
            _armorClass = inAC;

            CurrentHealth = _maxHealth;
        }

        public abstract string Describe();
    }
}
