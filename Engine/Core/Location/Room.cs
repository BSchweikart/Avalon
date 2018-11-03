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
        private string _descripRoom;
        private Monster _monster;
        private NPC _npc;


        public string Name { get; set; }
        public string Descrip { get; set; }
        //public Monster MonsterIsRoom { get { return Monster} }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }

        public Room(string name, string descrip)
        {
            Name = name;
            Descrip = descrip;
        }
    }

}


