using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        #region fields
        public int ID { get; set; }
        public string NameRoom { get; set; }
        public string DescripRoom { get; set; }
        //public Quest QuestIsHere { get; set; } // add at a later time
        public Monster MonsterIsHere { get; set; }
        public NPC NPCIsHere { get; set; }
        public int LocationNorth { get; set; }
        public int LocationEast { get; set; }
        public int LocationSouth { get; set; }
        public int LocationWest { get; set; }
        public List<Item> ItemRoom = new List<Item>();
        public List<Monster> MonsterRoom = new List<Monster>();
        public List<NPC> NPCRoom = new List<NPC>();
        #endregion

        public Room(int id, String name, String descrip, int exitNorth, int exitEast, int exitSouth, int exitWest, int idMonster, int idRmLoot, int idRmNPC)
        {
            ID = id;
            NameRoom = name;
            DescripRoom = descrip;
            //QuestIsHere = questIsHere; // used for later
            LocationNorth = exitNorth;
            LocationEast = exitEast;
            LocationSouth = exitSouth;
            LocationWest = exitWest;

            
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

            #region add Items
            if (idRmLoot > -1)
            {
                if (idRmLoot >= 400 && idRmLoot <= 404) // add weapons
                {
                    Weapon rmLoot = WorldGenerator.weapons.SingleOrDefault(ii => ii.ID == idRmLoot);
                    ItemRoom.Add(new Weapon(rmLoot.ID, rmLoot.Name, rmLoot.Description, rmLoot.Equiptable, rmLoot.Price, rmLoot.DamageMax));
                }
                
            }
            #endregion

            #region add NPC
            if (idRmNPC != -1)
            {
                if (idRmNPC == 100) 
                {
                    NPCIsHere = new NPC(WorldGenerator.NPCByID(idRmNPC));
                    NPCRoom.Add(NPCIsHere);
                }
            }
            #endregion
        }
    }
}