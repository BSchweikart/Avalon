using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        private int _id;                // Item ID
        private string _nameRoom;       // To hold the Room's name
        private string _roomDescript;   // To hold the Room's description
        private Monster _monsters;      //
        private NPC _npc;               //
        private int _exitNorth;         // To hold the Room's exit1 string
        private int _exitSouth;         // To hold the Room's exit2 string
        private int _exitEast;          // To hold the Room's exit3 string
        private int _exitWest;          // To hold the Room's exit4 string        
                                        


        public int ID { get { return _id; } set { _id = value; } }
        public string NameRoom { get { return _nameRoom; } set { _nameRoom = value; } }
        public string DiscRoom { get { return _roomDescript; } set { _roomDescript = value; } }
        public Monster RoomMonsters { get { return _monsters; } set { _monsters = value; } }
        public NPC RoomNPC { get { return _npc; } set { _npc = value; } }
        public int ExitNorth { get { return _exitNorth; } set { _exitNorth = value; } }
        public int ExitSouth { get { return _exitSouth; } set { _exitSouth = value; } }
        public int ExitEast { get { return _exitEast; } set { _exitEast = value; } }
        public int ExitWest { get { return _exitWest; } set { _exitWest = value; } }
        
       
        public Room(int id, string name, string descript, int exitn, int exits, int exite, int exitw)
        {
            ID = id;
            NameRoom = name;
            DiscRoom = descript;
            ExitNorth = exitn;
            ExitSouth = exits;
            ExitEast = exite;
            ExitWest = exitw;

        }   

    }

}


