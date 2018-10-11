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
        private string _disc;


        public string Name { get { return _name; } set { return _name = value; } }
        public string Disc { get { return _disc; } set { _disc = value; } }


        public Room(string name, string disc)
        {
            Name = name;
            Disc = disc;
        }
    }
}
