using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// have to look into how to populate this area with drops.

namespace Engine
{
    public class Treasure : Items
    {
        private string _name;   //  Name
        //private int _health;   // Spirt - Health
        //private int _mana;    // Mana holding for later v
        //private int _str;     // Strength
        //private int _wis;     // Wisdom
        //private int _dex;     // Dex holding for later ^

        public string Name { get { return _name; } set { return _name = value; } }
        //public int Health { get; set; }
        //public int Mana { get; set; }
        //public int STR { get; set; }
        //public int Wis { get; set; }
        //public int DEX { get; set; }

        public Treasure (string name)
        {
            Name = name;
        }

    }
}
