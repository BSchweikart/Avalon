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
        public static readonly List<Potion> Potions = new List<Potion>();
        public static readonly List<Treasure> Treasures = new List<Treasure>();
        public static readonly List<Weapon> Weapons = new List<Weapon>();
        public static readonly List<NPC> NPCs = new List<NPC>();
        public static readonly List<Room> Rooms = new List<Room>();


        public static Monster MonsterName(string name)
        {
            return ();
        }

        public static Potion PotionName(string name)
        {
            return ();
        }

        public static Treasure TreasureName(string name)
        {
            return ();
        }

        public static Weapon WeaponName(string name)
        {
            return ();
        }

        public static NPC NPCName(string name)
        {
            return ();
        }

        public static Room RoomName(string name)
        {
            return ();
        }


    }
}
