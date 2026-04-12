using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    // Used to help JSON serializer determine monster class when deserializing
    [JsonDerivedType(typeof(Minion), typeDiscriminator: "minion")]
    [JsonDerivedType(typeof(Elite), typeDiscriminator: "elite")]
    [JsonDerivedType(typeof(WorldBoss), typeDiscriminator: "worldBoss")]
    public abstract class Creature : IDescribable
    {
        // Private members to store values
        private string _name;
        private string _description;
        private int _level;
        private int _armorClass;

        private int _maxHealth;
        private MonsterType _monsterType;
        private DamageType _resists;
        private Classification _class;

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Level
        { 
            get { return _level; } 
            set 
            {
                if (value >= 1 && value <= 20)
                    _level = value;
                else if (value < 1)
                    _level = 1;
                else if (value > 20)
                {
                    _level = 20;
                }
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
                if (value > 0) 
                    _maxHealth = value;
                else
                    _maxHealth = 1;
            } 
        }


        [JsonConverter(typeof(JsonStringEnumConverter<Classification>))]
        public Classification MonsterClass { get { return _class; } set { _class = value; } }

        [JsonConverter(typeof(JsonStringEnumConverter<MonsterType>))]
        public MonsterType MonsterType { get { return _monsterType; } set { _monsterType = value; } }

        [JsonConverter(typeof(JsonStringEnumConverter<DamageType>))]
        public DamageType Resists { get { return _resists; } set { _resists = value; } }

        public bool Randomize { get; set; }

        [JsonConstructor]
        public Creature()
        {
            
        }

        public Creature(string inName, string inDesc, int inLevel, Classification inClass, MonsterType inType, DamageType inResists, bool inRand)
        {
            Name = inName;
            Description = inDesc;
            MonsterType = inType;
            Level = inLevel;
            Resists = inResists;
            MonsterClass = inClass;
            Randomize = inRand;

            ApplyRandomGen();
            
        }
        
        public Creature(string inName, string inDesc, int inLevel, int inAC, int inHP, Classification inClass, MonsterType inType, DamageType inResists, bool inRand)
        {
            Name = inName;
            Description = inDesc;
            Level = inLevel;
            MonsterType = inType;
            Resists = inResists;
            MonsterClass = inClass;
            Randomize = inRand;

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
                CurrentHealth = CurrentHealth + newHP;
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

        // An attempt to maintain randomness when loading
        
        public void ApplyRandomGen()
        {
            GetACByLevel();
            GetHealthByTypeAndLevel();
        }

        public override bool Equals(object obj)
        {
            try
            {
                // If object is null, return false
                if (obj == null)
                    return false;

                // Get obj as a creature
                if (obj is Creature c)
                {
                    // Compare Values
                    if (this.GetNameUpperCase() == c.GetNameUpperCase() &&
                        this.Level == c.Level &&
                        this.MonsterType == c.MonsterType &&
                        this.Resists == c.Resists &&
                        this.MonsterClass == c.MonsterClass)
                        return true;
                    else // Return false
                        return false;
                }
                else  // Return false
                    return false;
            }
            catch (Exception e)
            {
                // Error message
                MessageBox.Show($"Error while comparing monsters.\n{e.Message}", "ERROR: Comparing Monsters");
                return false;
            }
        }

        public static bool operator ==(Creature c1, Creature c2)
        {
            // Check for null values
            if (Object.Equals(c1, null))
            {
                if (Object.Equals(c2, null))
                    return true;
                else
                    return false;
            }
            else
            {
                // If not null, then evaluate normally
                return c1.Equals(c2);
            }
        }

        // Check to see if the creatures are not equal
        public static bool operator !=(Creature c1, Creature c2)
        {
            // If objects are not equal
            return !(c1 == c2);
        }

        private string GetNameUpperCase()
        {
            // Trim all whitespace from the name
            string trimmedName = string.Concat(Name.Where(c => !char.IsWhiteSpace(c)));

            // Return name in uppercase
            return trimmedName.ToUpper();
        }
    }
}