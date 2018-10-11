using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Potions : Items
    {
        private string _name;   //  Name
        private string _disc;
        //private int _health;   // Health
        //private int _mana;    // Mana
        //private int _str;     // Strength might add in 
        //private int _wis;     // Wisdom might add in
        //private int _dex;     // Dex might add in

        public string Name { get { return _name; } set { _name = value; } }
        public string Disc { get { return _disc; } set { _disc = value; } }
        //public int Health { get; set; }
        //public int Mana { get; set; }
        //public int STR { get; set; }
        //public int Wis { get; set; }
        //public int DEX { get; set; }

        public Potion (string name, string disc)
        {
            Name = name;
            Disc = disc;
        }
    }
}
