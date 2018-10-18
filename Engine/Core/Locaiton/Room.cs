using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        private int _id;        // Item ID
        private string _name;   //  Name
        private string _disc;
        private Monster _monster;
        private NPC _npc;
        private int _moveNorth;
        private int _moveSouth;
        private int _moveEast;
        private int _moveWest;

        public int ID { get { return _id; } set { _id = value; } }
        public string NameRoom { get { return _name; } set { _name = value; } }
        public string DiscRoom { get { return _disc; } set { _disc = value; } }
        public Monster MonsterRoom { get { return _monster; } set { _monster = value; } }
        public NPC NpcRoom { get { return _npc; } set { _npc = value; } }
        public int MoveNorth { get { return _moveNorth; } set { _moveNorth = value; } }
        public int MoveSouth { get { return _moveSouth; } set { _moveSouth = value; } }
        public int MoveEast { get { return _moveEast; } set { _moveEast = value; } }
        public int MoveWest { get { return _moveWest; } set { _moveWest = value; } }
    }

    

     
}
   
