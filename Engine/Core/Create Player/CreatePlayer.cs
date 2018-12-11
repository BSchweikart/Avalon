using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class CreatePlayer
    {
        public static void CreateAPlayer()
        {
            string name;
            string className = "";
            string raceName = "";
            int hpMax = 0;
            int gold = 0;
            int armor = 0;
            Faction faction = Faction.Dev;
            //Weapon equipt = null;           
            bool validClass = false;
            bool validRace = false;
            bool validFaction = false;

            #region Get Player Name
            Console.WriteLine("What is your name?");
            Console.Write("> ");
            name = CapWords.FirstCharToUpper(Console.ReadLine());
            #endregion

            #region Race Selection
            while (validRace == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose a race.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Elf, Dwarf, Gaint, Fairy, Dragon");
                Console.Write("> ");
                raceName = Console.ReadLine().ToLower();


                if (raceName == "elf")
                {
                    
                    gold = 200;
                    hpMax = 50;
                    armor = 4;
                    validRace = true;
                }
                else if (raceName == "dwarf")
                {
                    
                    gold = 200;
                    hpMax = 75;
                    armor = 5;
                    validRace = true;
                }
                else if (raceName == "gaint")
                {
                    
                    gold = 200;
                    hpMax = 100;
                    armor = 10;
                    validRace = true;
                }
                else if (raceName == "fairy")
                {
                    
                    gold = 200;
                    hpMax = 40;
                    armor = 3;
                    validRace = true;
                }
                else if (raceName == "dragon")
                {
                  
                    gold = 200;
                    hpMax = 125;
                    armor = 12;
                    validRace = true;
                }
                else
                {
                    Console.WriteLine("Pick a valid race");
                }
            }
            #endregion

            #region Class Selection
            while (validClass == false)
            {
                Console.WriteLine("Choose a class.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Warrior, Archer, Assassin, or Mage");
                Console.Write("> ");
                className = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.White;

                if (className == "warrior")
                {
                    validClass = true;
                    hpMax = 100 + hpMax;
                    armor = 10 + armor;
                    
                }
                else if (className == "archer")
                {
                    validClass = true;
                    hpMax = 50 + hpMax;
                    armor = 5 + armor;
                    
                }
                else if (className == "shaman")
                {
                    validClass = true;
                    hpMax = 75 + hpMax;
                    armor = 7 + armor;
                    
                }
                else if (className == "assassin")
                {
                    validClass = true;
                    hpMax = 50 + hpMax;
                    armor = 5 + armor;
                    
                }
                else if (className == "mage")
                {
                    validClass = true;
                    hpMax = 25 + hpMax;
                    armor = 3 + armor;
                    
                }
                else
                {
                    Console.WriteLine("Pick a valid class");
                }
            }
            #endregion

            #region Race Selection
            //while (validRace == false)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("Choose a race.");
            //    Console.ForegroundColor = ConsoleColor.Cyan;
            //    Console.WriteLine("Elf, Dwarf, Gaint, Fairy, Dragon");
            //    Console.Write("> ");
            //    raceName = Console.ReadLine().ToLower();
                

            //    if (raceName == "elf")
            //    {
            //        validRace = true;
            //        gold = 200;
            //        armor = 5 + armor;
            //    }
            //    else if (raceName == "dwarf")
            //    {
            //        validRace = true;
            //        gold = 200;
            //    }
            //    else if (raceName == "gaint")
            //    {
            //        validRace = true;
            //        gold = 200;
            //    }
            //    else if (raceName == "fairy")
            //    {
            //        validRace = true;
            //        gold = 200;
            //    }
            //    else if (raceName == "dragon")
            //    {
            //        validRace = true;
            //        gold = 200;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Pick a valid race");
            //    }
            //}
            #endregion

            #region Faction Selection
            while (validFaction == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("To what faction do you belong?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Light, Dark > ");
                Console.Write("> ");
                string strFaction = CapWords.FirstCharToUpper(Console.ReadLine());

                if (strFaction == Faction.Light.ToString() || strFaction == Faction.Dark.ToString() || strFaction == Faction.Dev.ToString())
                {
                    faction = (Faction)Enum.Parse(typeof(Faction), strFaction, true);
                    validFaction = true;

                }
            }
            #endregion

            Console.ForegroundColor = ConsoleColor.White;

            #region Create Player
            Player._player = new Player
            (
                name, CapWords.FirstCharToUpper(raceName), CapWords.FirstCharToUpper(className), hpMax, hpMax, 
                armor, gold, WorldGenerator.WeaponByID(401), false, true, faction
            );
            #endregion

            Console.WriteLine("Loading game please wait");
            SavePlayerData.SaveGameData(Player._player); // save player information
            Console.Clear(); // clear the Console to clean it up
        }
        #region Load Player Data
        public static void CreateFromLoad(Player loadPlayer)
        {
            Player _player = new Player
            (
              loadPlayer.NamePlayer, loadPlayer.RacePlayer, loadPlayer.ClassPlayer, loadPlayer.HpCurrent, loadPlayer.HpMax, 
              loadPlayer.Armor,loadPlayer.Gold, loadPlayer.Equipt, loadPlayer.IsDead, loadPlayer.Attackable, loadPlayer.Factions
            );
        }
        #endregion
    }
}

           

