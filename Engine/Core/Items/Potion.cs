using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Potion : Item
    {
        private int _id;        // Item ID
        private string _name;   //  Name
        private string _disc;
        //private int _health;   // Health
        //private int _mana;    // Mana
        //private int _str;     // Strength might add in 
        //private int _wis;     // Wisdom might add in
        //private int _dex;     // Dex might add in
        

        public Potion(int id, string name, string disc) : base(id, name, disc)
        {
            ID = id;
            Name = name;
            Disc = disc;
        }
    }
}
