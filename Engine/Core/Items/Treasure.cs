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
        


        public Treasure(int id, string name, string description) : base (id, name, description, false, 0)
        {
            ID = id;
            Name = name;
            Description = description;
        }

    }
}
