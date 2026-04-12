using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    // Class representing a loot item. Each item has a name, value in gold, and a description.
    public class Loot : IDescribable, ICloneable
    {
        // The item's value
        private int _value;

        // Name of the item
        public string Name { get; set; }
        // Item's desctiption
        public string Description { get; set; }
        // Item's value: can't go below 0
        public int Value { get { return _value; } set { if (value < 0) value = 0; else _value = value; } }

        // Whether or not the item is magical
        public bool IsMagical { get; set; }

        // Constructor used to deserialize the object
        [JsonConstructor]
        public Loot() { }

        // Constructor
        public Loot(string inName, string inDesc, int inValue, bool isMagic)
        {
            Name = inName;
            Description = inDesc;
            Value = inValue;
            IsMagical = isMagic;
        }

        // Returns formated description of the item
        public string Describe()
            => $"NAME: {Name}\nVALUE: {Value}gp\n{(IsMagical == false ? "MUNDANE" : "MAGIC")} ITEM\n{Description}";

        // Returns a cloned item with the same properties 
        public object Clone()
        {
            // Return a clone
            return new Loot()
            {
                Name = this.Name,
                Description = this.Description,
                Value = this.Value,
                IsMagical = this.IsMagical
            };
        }

        public override string ToString()
            => Name;
    }
}
