using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_BestiaryFinal
{
    // Class representing a loot item. Each item has a name, value in gold, and a description.
    public class Loot : IDescribable
    {
        private int _value;

        public string Name { get; set; }
        public string Description { get; set; }
        public int Value { get { return _value; } set { if (value < 0) value = 0; _value = value; } }

        public Loot(string inName, string inDesc, int inValue)
        {
            Name = inName;
            Description = inDesc;
            Value = inValue;
        }

        public string Describe()
            => $"NAME: {Name}\nVALUE: {Value}gp\n{Description}";

        public override string ToString()
            => Name;
    }
}
