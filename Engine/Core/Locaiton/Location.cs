using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Set up the base for location

namespace Engine
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public Quest QuestIsHere { get; set; }
        public Monster MonsterIsHere { get; set; }
        public Location LocationToNorth { get; set; }
        public Location LocationToEast { get; set; }
        public Location LocationToSouth { get; set; }
        public Location LocationToWest { get; set; }



        public Location(int id, string name, string descrip, Quest questIsHere = null, Monster monsterIsHere = null)
        {
            ID = id;
            Name = name;
            Descrip = descrip;
            QuestIsHere = questIsHere;
            MonsterIsHere = monsterIsHere;
        }
    }
}
