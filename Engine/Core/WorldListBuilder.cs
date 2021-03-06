﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/**
 * This is the area that will be used to populate the lists that the other sections will use.
 * This is the section that will use the StreamReader function and set the values.
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
            #region Items ListsBuilder
            using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Treasure.csv")) //start building 
            {
                while (!reader.EndOfStream)
                {
                    string[] line = ReadNextLine(reader);
                    WorldGenerator.treasures.Add(new Treasure(int.Parse(line[0]), line[1], line[2]));
                }
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
                    WorldGenerator.weapons.Add(new Weapon(int.Parse(line[0]), line[1], line[2], bool.Parse(line[3]), int.Parse(line[4]), line[5]));
                }
            }
            #endregion

            #region Creature ListBulder
            #region Monster
            using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Monsters.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = ReadNextLine(reader); 
                    WorldGenerator.monsters.Add
                    (new Monster(int.Parse(line[0]),line[1],line[2],line[3],int.Parse(line[4]),int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7]), int.Parse(line[8]), bool.Parse(line[9]),bool.Parse(line[10]),Faction.Dev));
                }
            }
            #endregion

            #region NPC
            using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/NPC.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = ReadNextLine(reader);
                    WorldGenerator.npcs.Add(new NPC(int.Parse(line[0]), line[1], line[2], int.Parse(line[3]), int.Parse(line[4]), bool.Parse(line[5]), bool.Parse(line[6]), Faction.Dev));
                }
            }
            #endregion

            #region Race
            using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Race.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = ReadNextLine(reader);
                    WorldGenerator.races.Add(new Race(line[0], line[1]));
                }
            }
            #endregion

            #region Class
            using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Classes.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = ReadNextLine(reader);
                    WorldGenerator.classes.Add(new Class(line[0], line[1]));
                }
            }
            #endregion
            #endregion

            #region Rooms
            using (StreamReader reader = File.OpenText(@"../../.../Engine/Docs/Rooms.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = ReadNextLine(reader);

                    WorldGenerator.Location.Add
                        (
                        new Room(int.Parse(line[0]),line[1], line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]), int.Parse(line[7]), int.Parse(line[8]),int.Parse(line[9]))
                        );
                }
            }
            #endregion
      }
   } 
}
