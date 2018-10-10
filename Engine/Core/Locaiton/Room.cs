using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        private string _name;   //  Name
       

        public string Name { get { return _name; } set { return _name = value; } }
       

        public Room(string name)
        {
            Name = name;
        }
    }
}
