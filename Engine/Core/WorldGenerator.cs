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
        public static readonly List<Room> Location = new List<Room>();
        public static readonly List<Treasure> treasures = new List<Treasure>();
        public static readonly List<Monster> monsters = new List<Monster>();
        public static readonly List<Potion> potions = new List<Potion>();
        public static readonly List<Weapon> weapons = new List<Weapon>();
        public static readonly List<NPC> npcs = new List<NPC>();
        public static readonly List<Item> items = new List<Item>();
        public static List<Player> players = new List<Player>();
        public static List<Class> classes = new List<Class>();
        public static List<Race> races = new List<Race>();

        public static Room RoomByID(int id)
        {
            return Location.SingleOrDefault(x => x.ID == id);
        }
        //public static Room RoomByName(string name)
        //{
        //    return Location.SingleOrDefault(x => x.Name == name);
        //}
        public static Weapon WeaponByID(int id)
        {
            return weapons.SingleOrDefault(x => x.ID == id);
        }
        public static Weapon WeaponByName(string name)
        {
            return weapons.SingleOrDefault(x => x.Name == name);
        }
        public static Item ItemByID(int id)
        {
            return items.SingleOrDefault(x => x.ID == id);
        }
        public static Item ItemByName(string name)
        {
            return items.SingleOrDefault(x => x.Name == name);
        }
    }
}
