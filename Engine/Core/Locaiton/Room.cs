using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        private int _id;            // Item ID
        private string _name;       //  Name
        private string _disc;       // Description
        private Monster _monster;   // 
        private NPC _npc;           //
        private int _exitNorth;     // E
        private int _exitSouth;     //
        private int _exitEast;      //
        private int _exitWest;      //

        public int ID { get { return _id; } set { _id = value; } }
        public string NameRoom { get { return _name; } set { _name = value; } }
        public string DiscRoom { get { return _disc; } set { _disc = value; } }
        public Monster MonsterRoom { get { return _monster; } set { _monster = value; } }
        public NPC NpcRoom { get { return _npc; } set { _npc = value; } }
        public int ExitNorth { get { return _exitNorth; } set { _exitNorth = value; } }
        public int ExitSouth { get { return _exitSouth; } set { _exitSouth = value; } }
        public int ExitEast { get { return _exitEast; } set { _exitEast = value; } }
        public int ExitWest { get { return _exitWest; } set { _exitWest = value; } }
    }

    

     
}
   
