using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        private int _id;
        private string _nameRoom;
        private string _descrip;
        private Monster _monster;
        private int _locationNorth;
        private int _locationEast;
        private int _locationSouth;
        private int _locationWest;

        public int ID { get { return _id; } set { _id = value; } }
        public string NameRoom { get { return _nameRoom; } set { _nameRoom = value; } }
        public string Descrip { get { return _descrip; } set { _descrip = value; } }
        //public Quest QuestIsHere { get; set; }
        public Monster MonsterIsHere { get { return _monster; } set { _monster = value; } }
        public int LocationNorth { get { return _locationNorth; } set { _locationNorth = value; } }
        public int LocationEast { get { return _locationEast; } set { _locationEast = value; } }
        public int LocationSouth { get { return _locationSouth; } set { _locationSouth = value; } }
        public int LocationWest { get { return _locationWest; } set { _locationWest = value; } }
        public List<Item> ItemRoom = new List<Item>();
        public List<Monster> MonsterRoom = new List<Monster>();

        public Room(int id, string name, string descrip, int exitNorth, int exitEast, int exitSouth, int exitWest)
        {
            ID = id;
            this.NameRoom = name;
            Descrip = descrip;
            //QuestIsHere = questIsHere;
            LocationNorth = exitNorth;
            LocationEast = exitEast;
            LocationSouth = exitSouth;
            LocationWest = exitWest;

            //need to add monster spwan
        }

        
    }

}


