using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        //public Quest QuestIsHere { get; set; }
        public Monster MonsterIsHere { get; set; }
        public int LocationNorth { get; set; }
        public int LocationEast { get; set; }
        public int LocationSouth { get; set; }
        public int LocationWest { get; set; }



        public Room(int id, string name, string descrip, int exitNorth, int exitEast, int exitSouth, int exitWest)
        {
            ID = id;
            Name = name;
            Descrip = descrip;
            //QuestIsHere = questIsHere;
            LocationNorth = exitNorth;
            LocationEast = exitEast;
            LocationSouth = exitSouth;
            LocationWest = exitWest;
        }
    }

}


