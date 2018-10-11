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
 * The list should start working and have a base for the others
 * 
 * 
 */

namespace Engine
{
   public static class WorldListBuilder
   { 
      private static string[] ReadNextLine(StreamReader reader)
      {
          string[] line = reader.ReadLine().Split(' ');
          return line;
      }
       
      public static void Generate()
      {
         using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Treasure.txt")) //start building 
         {
             while (!reader.EndOfStream)
             {
                 string name = reader.ReadLine();
                 string disc = reader.Readline();
                 WorldGenerator.Treasures.Add(new Treasure(name, disc));
             }
         }
         
         using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Monsters.txt")) // Start building 
         {
             while (!reader.EndOfStream)
             {
                 string name = reader.ReadLine();
                 string disc = reader.Readline();
                 WorldGenerator.Monsters.Add(new Monster(name, disc));
             }
         }
          
         using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Rooms.txt"))
         {
             while (!reader.EndOfStream)
             {
                 string name = reader.ReadLine();
                 string disc = reader.Readline();
                 WorldGenerator.Rooms.Add(new Room(name, disc));
             }
         }
          
         using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Potions.txt"))
         {
             while (!reader.EndOfStream)
             {
                 string name = reader.ReadLine();
                 string disc = reader.Readline();
                 WorldGenerator.Potions.Add(new Potion(name, disc));
             }
         }
          
         using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Weapons.txt"))
         {
             while (!reader.EndOfStream)
             {
                 string name = reader.ReadLine();
                 string disc = reader.Readline();
                 WorldGenerator.Weapons.Add(new Weapon(name, disc));
             }
         }
          
         using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/NPC.txt"))
         {
             while (!reader.EndOfStream)
             {
                 string name = reader.ReadLine();
                 string disc = reader.Readline();
                 WorldGenerator.NPCs.Add(new NPC(name, disc));
             }
         }
           //string[] weapons = File.ReadAllLines(@"../../../Engine/Docs/Weapon.txt");
        //string[] classes = File.ReadAllLines(@"../../../Engine/Docs/Classes.txt");
        //string[] monsters = File.ReadAllLines(@"../../../Engine/Docs/Monster.txt");
        //string[] NPC = File.ReadAllLines(@"../../../Engine/Docs/NPC.txt");
        //string[] player = File.ReadAllLines(@"../../../Engine/Docs/Player.txt");
        //string[] potions = File.ReadAllLines(@"../../../Engine/Docs/Potions.txt");
        //string[] races = File.ReadAllLines(@"../../../Engine/Docs/Races.txt");
        //string[] rooms = File.ReadAllLines(@"../../../Engine/Docs/Rooms.txt");
        //string[] treasure = File.ReadAllLines(@"../../../Engine/Docs/Treasure.txt");
        //string[] levels = File.ReadAllLines(@"../../../Engine/Docs/Level.txt");      

      }
   } 
}
