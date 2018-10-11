using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Items
    {
        private string _name;   //  Name
        //private int _health;   // Health
        //private int _mana;    // Mana
        //private int _str;     // Strength
        //private int _wis;     // Wisdom
        //private int _dex;     // Dex

        public string Name { get { return _name; } set { _name = value; } }
        //public int Health { get; set; }
        //public int Mana { get; set; }
        //public int STR { get; set; }
        //public int Wis { get; set; }
        //public int DEX { get; set; }

        public Items(string name)
        {
            Name = name;
        }
    }
}
