using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    public class Ability : IDescribable
    {
        private string _name;
        private string _description;
        private int _power;
        private int _cost;

        private int minPow = 0;
        private int maxPow = 2000;

        private int minCost = 0;
        private int maxCost = 50;

        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Power 
        { 
            get 
            { 
                return _power; 
            }
            set
            {
                if (value >= minPow && value <= maxPow)
                    _power = value;
            }
        }
        public int Cost
        { 
            get 
            {
                return _cost; 
            } 
            set
            {
                if (value >= minCost && value <= maxCost)
                    _cost = value;
            }
        }
        public DamageType DamageType { get; set; }

        [JsonConstructor]
        public Ability() { }

        public Ability(string inName, string inDesc, int inPower, int inCost, DamageType inDT)
        {
            Name = inName;
            Description = inDesc;
            Power = inPower;
            Cost = inCost;

            DamageType = inDT;
        }

        public string Describe()
        {
            string desc = $"NAME: {Name}\n********\n{Description}\n********\nPOWER: {Power}\n********\nDAMAGE TYPE: {DamageType.ToString()}\n********\nMANA COST: {Cost}";
            return desc;
        }

        public override string ToString()
            => Name;
    }
}
