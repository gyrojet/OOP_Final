using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace OOP_BestiaryFinal
{
    public class Minion : Creature
    {
        private int _minAppearing;
        private int _maxAppearing;

        public int MinAppearing { get { return _minAppearing; } set { if (value > 0) _minAppearing = value; else _minAppearing = 1; } }
        public int MaxAppearing { get { return _maxAppearing; } set { if (value > _minAppearing) _maxAppearing = value; else _maxAppearing = _minAppearing; } }

        [JsonConstructor]
        public Minion() { }

        public Minion(string inName, string inDesc, int inLevel, Classification inClass, MonsterType inType, DamageType inResists, int inMin, int inMax) 
            : base(inName, inDesc, inLevel, inClass, inType, inResists)
        {
            MinAppearing = inMin;
            MaxAppearing = inMax;
        }

        public Minion(string inName, string inDesc, int inLevel, int inAC, int inHP, Classification inClass, MonsterType inType, DamageType inResists, int inMin, int inMax)
            : base(inName, inDesc, inLevel, inAC, inHP, inClass, inType, inResists)
        {
            MinAppearing = inMin;
            MaxAppearing = inMax;
        }

        public override string Describe()
           => $"{Name} (MINION)\n{Description}\n********\nLEVEL: {Level}\n\nHP: {CurrentHealth}\nAC: {AC}\nRESISTS: {Resists}\n\nTYPE: {MonsterType.ToString()}\nNO. APPEARING: {MinAppearing.ToString()}-{MaxAppearing.ToString()}\n********";
    }
}
