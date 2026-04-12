using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;

namespace OOP_BestiaryFinal
{
    // A class representing a minion
    public class Minion : Creature
    {
        // The minimum and maximum number of creatures that will appear
        private int _minAppearing;
        private int _maxAppearing;

        
        // Get/set min appearing: Can never be below 1
        public int MinAppearing { get { return _minAppearing; } set { if (value > 0) _minAppearing = value; else _minAppearing = 1; } }

        // Get/set max appearing: can never be less than the minimum number
        public int MaxAppearing { get { return _maxAppearing; } set { if (value < _minAppearing) _maxAppearing = _minAppearing; else _maxAppearing = value; } }

        // Used when deserializing objects
        [JsonConstructor]
        public Minion() { }

        //  Cnstructor with random ac/hp
        public Minion(string inName, string inDesc, int inLevel, Classification inClass, MonsterType inType, DamageType inResists, bool inRand,int inMin, int inMax) 
            : base(inName, inDesc, inLevel, inClass, inType, inResists, inRand)
        {
            MinAppearing = inMin;
            MaxAppearing = inMax;
        }

        // Constructor with fixed ac/hp
        public Minion(string inName, string inDesc, int inLevel, int inAC, int inHP, Classification inClass, MonsterType inType, DamageType inResists, bool inRand, int inMin, int inMax)
            : base(inName, inDesc, inLevel, inAC, inHP, inClass, inType, inResists, inRand)
        {
            MinAppearing = inMin;
            MaxAppearing = inMax;
        }

        // Return a formated description
        public override string Describe()
           => $"{Name} (MINION)\n{Description}\n********\nLEVEL: {Level}\n\nHP: {CurrentHealth}\nAC: {AC}\nRESISTS: {Resists}\n\nTYPE: {MonsterType.ToString()}\nNO. APPEARING: {MinAppearing.ToString()}-{MaxAppearing.ToString()}\n********";
    }
}
