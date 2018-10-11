using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/** 
 * Format for weapons
 * Sprit - HP
 * STR - AP
 * Wis -  Int
 * Dex - Agi
 *
 *This might end up being to much at the start
 * ex. caster fire ball does % base of int
 * or Fire Ball damage = 168% of INT so if the mage has 100 int the FB damage would be 168 damage but then you have to add in
 * base damage so lets say base damage is 10 then it would be 10+(100*168%) would be 178 damage. This can be fixed in tuning
 *  Might look into swaping out the [MOD] for weapon damage which would allow tuning to be a little better just more math.
 */


namespace Engine
{
    public class Weapon : Items
    {
        private string _name;   //  Name
        //private int _health;   // Spirt - Health
        //private int _mana;    // Mana
        //private int _str;     // Strength
        //private int _wis;     // Wisdom
        //private int _dex;     // Dex

        public string Name { get { return _name; } set { return _name = value; } }
        //public int Health { get; set; }
        //public int Mana { get; set; }
        //public int STR { get; set; }
        //public int Wis { get; set; }
        //public int DEX { get; set; }

        public Weapon (string name)
        {
            Name = name;
        }
    }
}
