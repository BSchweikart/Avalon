using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        //private int _id;
        //private string _nameRoom;
        //private string _descripRoom;
        //private Monster _monster;
        //private int _locationNorth;
        //private int _locationEast;
        //private int _locationSouth;
        //private int _locationWest;

        public int ID { get; set; }
        public string NameRoom { get; set; }
        public string DescripRoom { get; set; }
        //public Quest QuestIsHere { get; set; }
        public Monster MonsterIsHere { get; set; }
        public int LocationNorth { get; set; }
        public int LocationEast { get; set; }
        public int LocationSouth { get; set; }
        public int LocationWest { get; set; }
        public List<Item> ItemRoom = new List<Item>();
        public List<Monster> MonsterRoom = new List<Monster>();

        public Room(int id, String name, String descrip, int exitNorth, int exitEast, int exitSouth, int exitWest, int idMonster)
        {
            ID = id;
            NameRoom = name;
            DescripRoom = descrip;
            //QuestIsHere = questIsHere;
            LocationNorth = exitNorth;
            LocationEast = exitEast;
            LocationSouth = exitSouth;
            LocationWest = exitWest;

            //need to add monster spwan
            #region add monsters
            if(idMonster !=12)
            {
                if(idMonster > -1)
                {
                    Random rand = new Random();
                    int mobRm = RandomNumGen.NumberBetween(0,13);
                    MonsterIsHere = new Monster(WorldGenerator.monsters[mobRm]);
                    MonsterRoom.Add(MonsterIsHere);
                }
            }
            else
            {
                this.MonsterRoom.Add(WorldGenerator.MonsterByID(idMonster));
            }
            #endregion
        }


    }

}


