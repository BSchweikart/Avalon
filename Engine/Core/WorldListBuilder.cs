using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


// had to add this in by hand would not pop the fields.
/**
 * This is the area that will be used to populate the lists that the other sections will use.
 * This is the section that will use the StreamReader function and set the values.
 * 
 * 
 * 
 * 
 * 
 */

namespace Engine
{
    public class WorldListBuilder
    {
        string[] weapons = File.ReadAllLines(@"../../../Core/Docs/Weapon.txt");
        string[] classes = File.ReadAllLines(@"../../../Core/Docs/Classes.txt");
        string[] monsters = File.ReadAllLines(@"../../../Core/Docs/Monster.txt");
        string[] NPC = File.ReadAllLines(@"../../../Core/Docs/NPC.txt");
        string[] player = File.ReadAllLines(@"../../../Core/Docs/Player.txt");
        string[] potions = File.ReadAllLines(@"../../../Core/Docs/Potions.txt");
        string[] races = File.ReadAllLines(@"../../../Core/Docs/Races.txt");
        string[] rooms = File.ReadAllLines(@"../../../Core/Docs/Rooms.txt");
        string[] treasure = File.ReadAllLines(@"../../../Core/Docs/Treasure.txt");
        string[] levels = File.ReadAllLines(@"../../../Core/Docs/Level.txt");

        //test to build the treasure
        //public static void Build()
        //{
        //    using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Treasure.txt"))
        //    {
        //        while (!reader.EndOfStream)
        //        {
        //            string name = reader.ReadLine();


        //            // WorldGenerator.Treasure.Add(new Treasure(name));
        //        }
        //    }
        //}


    }
}
