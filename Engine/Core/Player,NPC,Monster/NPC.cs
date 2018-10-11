using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC
    {
        private string _name;   //  Name
        private string _disc;


        public string Name { get { return _name; } set { return _name = value; } }
        public string Disc { get { return _disc; } set { _disc = value; } }


        public NPC(string name, string disc)
        {
            Name = name;
            Disc = disc;
        }
    }
}
