using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// have to look into how to populate this area with drops.

namespace Engine
{
    public class Treasure : Item
    {
        private int _id;        // Item ID
        private string _name;   //  Name
        private string _disc;
        

        public Treasure(int id, string name, string disc) : base(id, name, disc)
        {
            ID = id;
            Name = name;
            Disc = disc;
        }

    }
}
