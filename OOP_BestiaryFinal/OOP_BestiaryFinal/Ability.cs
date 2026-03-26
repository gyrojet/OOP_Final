using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
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

        public Ability(string inName, string inDesc, int inPower, int inCost, DamageType inDT)
        {
            _name = inName;
            _description = inDesc;
            _power = inPower;
            _cost = inCost;

            DamageType = inDT;
        }

        public string Describe()
        {
            string desc = $"NAME: {Name}\n********\nDescription: {Description}\n********\nPOWER: {Power}\n********\nDAMAGE TYPE: {DamageType.ToString()}\n********\nMANA COST: {Cost}";
            return desc;
        }

        public override string ToString()
            => Name;
    }
}
