using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
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
                if (value > maxPow)
                    _power = maxPow;
                else if (value < minPow)
                    _power = minCost;
                else
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
                if (value > maxCost)
                    _cost = maxCost;
                else if (value < minCost)
                    _cost = minCost;
                else
                    _cost = value;
            }
        }
        [JsonConverter(typeof(JsonStringEnumConverter<DamageType>))]
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

        // To check object equality, check to see if an ability matches the name, power, cost and damage type.
        public override bool Equals(object obj)
        {
            try
            {
                // If ability is null, return fals
                if (obj == null)
                    return false;

                // Get object as an ability
                //Ability a = obj as Ability;

                if (obj is Ability a)
                {
                    // If the object is the same as the current:
                    if (this.GetNameUpperCase() == a.GetNameUpperCase() &&
                        this.Power == a.Power &&
                        this.Cost == a.Cost &&
                        this.DamageType == a.DamageType)
                        return true; // Return true
                    else
                        return false; //return false
                }
                else
                    return false;

            }
            catch (Exception ex)
            {
                // If an error occurs:
                MessageBox.Show($"Error while comparing abilities.\n{ex.Message}", "ERROR: Comparing Abilities");
                return false;
            }
        }

        public static bool operator ==(Ability a1, Ability a2)
        {
            // If values are null:
            if (Object.Equals(a1, null))
            {
                if (Object.Equals(a2, null))
                    return true;
                else
                    return false;
            }
            else
            {
                // If not null, then evaluate normally
                return a1.Equals(a2);
            }
        }

        public static bool operator !=(Ability a1, Ability a2)
        {
            return !(a1 == a2);
        }

        // Get name In Uppercase, without any spaces or whitespace
        private string GetNameUpperCase()
        {
            // Trim all whitespace from the name
            string trimmedName = string.Concat(Name.Where(c => !char.IsWhiteSpace(c)));

            return trimmedName.ToUpper();
        }
    }
}
