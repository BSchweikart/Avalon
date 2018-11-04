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
        public static readonly List<Room> location = new List<Room>();
        public static readonly List<Treasure> treasures = new List<Treasure>();
        public static readonly List<Monster> monsters = new List<Monster>();
        public static readonly List<Potion> potions = new List<Potion>();
        public static readonly List<Weapon> weapons = new List<Weapon>();
        public static readonly List<NPC> npcs = new List<NPC>();
        public static List<Player> players = new List<Player>();
        public static List<Class> classes = new List<Class>();
        public static List<Race> races = new List<Race>();


    }
}
