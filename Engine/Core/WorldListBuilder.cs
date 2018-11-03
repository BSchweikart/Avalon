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
          string[] line = reader.ReadLine().Split(',');
          return line;
      }
       
      public static void Generate()
      {
         using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Treasure.csv")) //start building 
            {
             while (!reader.EndOfStream)
             {
                    string[] line = ReadNextLine(reader);
                    WorldGenerator.treasures.Add(new Treasure(line[0], line[1]));
             }
         }

         using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Monsters.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = ReadNextLine(reader); 
                    WorldGenerator.monsters.Add(new Monster(int.Parse(line[0]),line[1],int.Parse(line[2]),int.Parse(line[3]),int.Parse(line[4]),int.Parse(line[5]),int.Parse(line[6]), bool.Parse(line[7]), bool.Parse(line[8])));
                }
            }

         using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Rooms.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = ReadNextLine(reader);

                    WorldGenerator.location.Add(new Room(int.Parse(line[0]),line[1], line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6])));
                }//need to fix out of bounds
            }

         using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Potions.csv"))
         {
             while (!reader.EndOfStream)
             {
                    string[] line = ReadNextLine(reader);
                    WorldGenerator.potions.Add(new Potion(int.Parse(line[0]), line[1], line[2], int.Parse(line[3])));
             }
         }
          
         using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Weapons.csv"))
         {
             while (!reader.EndOfStream)
             {
                    string[] line = ReadNextLine(reader);
                    WorldGenerator.weapons.Add(new Weapon(line[0], line[1]));
             }
         }
          
         using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/NPC.csv"))
         {
             while (!reader.EndOfStream)
             {
                    string[] line = ReadNextLine(reader);
                    WorldGenerator.npcs.Add(new NPC(int.Parse(line[0]), line[1], line[2], int.Parse(line[3]), int.Parse(line[4]),bool.Parse(line[5]),bool.Parse(line[6])));
             }
         }

         using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Race.csv"))
         {
             while (!reader.EndOfStream)
             {
                  string[] line = ReadNextLine(reader);
                  WorldGenerator.races.Add(new Race(line[0], line[1]));
             }
         }

         using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Classes.csv"))
         {
             while (!reader.EndOfStream)
             {
                  string[] line = ReadNextLine(reader);
                  WorldGenerator.classes.Add(new Class(line[0], line[1]));
             }
         }
            WorldGenerator.players.Add(new Player(""));
        }
   } 
}
