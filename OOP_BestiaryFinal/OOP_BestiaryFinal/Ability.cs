using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    // Describes a move or ability
    public class Ability : IDescribable
    {
        // Private fields to store data
        // Name of ability
        private string _name;
        // Description of ability
        private string _description;
        // Ability's power level
        private int _power;
        // Ability's cost to use
        private int _cost;

        //  Min and max values of a move's power
        private int minPow = 0;
        private int maxPow = 2000;

        // Min and max values of a move's cost
        private int minCost = 0;
        private int maxCost = 50;

        //get/set name
        public string Name { get { return _name; } set { _name = value; } }
        // Get/set description
        public string Description { get { return _description; } set { _description = value; } }
        public int Power 
        { 
            get 
            {   // get power
                return _power; 
            }
            set
            {   // Power must be between min and max
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
                // Get cost
                return _cost; 
            } 
            set
            {
                // Cost must be between min and max
                if (value > maxCost)
                    _cost = maxCost;
                else if (value < minCost)
                    _cost = minCost;
                else
                    _cost = value;
            }
        }
        //Get/set damage type
        [JsonConverter(typeof(JsonStringEnumConverter<DamageType>))]
        public DamageType DamageType { get; set; }

        // Used to deserialize with JSON
        [JsonConstructor]
        public Ability() { }

        // Constructor
        public Ability(string inName, string inDesc, int inPower, int inCost, DamageType inDT)
        {
            Name = inName;
            Description = inDesc;
            Power = inPower;
            Cost = inCost;

            DamageType = inDT;
        }

        // Return formated description of ability
        public string Describe()
        {
            string desc = $"NAME: {Name}\n********\n{Description}\n********\nPOWER: {Power}\n********\nDAMAGE TYPE: {DamageType.ToString()}\n********\nMANA COST: {Cost}";
            return desc;
        }

        // Returns name
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
            // If abilities don't match:
            return !(a1 == a2);
        }

        // Get name In Uppercase, without any spaces or whitespace
        private string GetNameUpperCase()
        {
            // Trim all whitespace from the name
            string trimmedName = string.Concat(Name.Where(c => !char.IsWhiteSpace(c)));

            // Return trimmed string as all uppercase
            return trimmedName.ToUpper();
        }

        // Gets hash code based on properties
        public override int GetHashCode()
        {
            // Create new hash string
            string hashStr = this.Name +
                             this.Description +
                             this.Power +
                             this.Cost +
                             this.DamageType;
            // Get hash code based on properties
            return hashStr.GetHashCode();
        }
    }
}
