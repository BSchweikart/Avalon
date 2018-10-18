using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**
 * This is the area that will populate  Avalon with the items and location and others
 * room for notes at a later time
 * 
 * 
 * 
 * 
 * 
 * 
 */


namespace Engine
{ 

    public static class WorldGenerator
    {
	    public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Potion> Potions = new List<Potion>();
        public static readonly List<Treasure> Treasures = new List<Treasure>();
        public static readonly List<Weapon> Weapons = new List<Weapon>();
        public static readonly List<NPC> NPCs = new List<NPC>();
        public static readonly List<Room> Rooms = new List<Room>();

        public static Monster MonsterID(int id)
        {
            return Monsters.SingleOrDefault();
        }
        public static Monster MonsterName(string name)
        {
            return Monsters.SingleOrDefault();
        }

        public static Item ItemId(int id)
        {
            return Items.SingleOrDefault();
        }

        public static Item ItemName(string name)
        {
            return Items.SingleOrDefault();
        }

        public static NPC NPCId(int id)
        {
            return NPCs.SingleOrDefault();
        }
        public static NPC NPCName(string name)
        {
            return NPCs.SingleOrDefault();
        }

        public static Room RoomId(int id)
        {
            return Rooms.SingleOrDefault();
        }
        public static Room RoomName(string name)
        {
            return Rooms.SingleOrDefault();
        }


    }
}
