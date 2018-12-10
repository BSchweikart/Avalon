using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Need to add to the world.

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
