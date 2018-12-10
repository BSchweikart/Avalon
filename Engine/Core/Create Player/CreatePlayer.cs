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

            #region Class Selection
            while (validClass == false)
            {
                Console.WriteLine("Choose a class.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Warrior, Archer, Healer, Assassin, or Mage");
                className = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.White;

                if (className == "warrior")
                {
                    gold = 100;
                    validClass = true;
                }
                else if (className == "archer")
                {
                    gold = 200;
                    validClass = true;
                }
                else if (className == "healer")
                {
                    gold = 300;
                    validClass = true;
                }
                else if (className == "assassin")
                {
                    gold = 400;
                    validClass = true;
                }
                else if (className == "mage")
                {
                    gold = 500;
                    validClass = true;
                }
                else
                {
                    Console.WriteLine("Pick a valid class");
                }
            }
            #endregion

            #region Race Selection
            while (validRace == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose a race.");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Elf, Dwarf, Gaint, Fairy, Dragon");
                raceName = Console.ReadLine().ToLower();
                

                if (raceName == "elf")
                {
                    validRace = true;
                    hpMax = 100;
                }
                else if (raceName == "dwarf")
                {
                    validRace = true;
                    hpMax = 100;
                }
                else if (raceName == "gaint")
                {
                    validRace = true;
                    hpMax = 100;
                }
                else if (raceName == "fairy")
                {
                    validRace = true;
                    hpMax = 100;
                }
                else if (raceName == "dragon")
                {
                    validRace = true;
                    hpMax = 100;
                }
                else
                {
                    Console.WriteLine("Pick a valid race");
                }
            }
            #endregion

            #region Faction Selection
            while (validFaction == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("To what faction do you belong?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Light, Dark > ");
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
                name, CapWords.FirstCharToUpper(className), CapWords.FirstCharToUpper(raceName), hpMax, hpMax, 
                gold, WorldGenerator.WeaponByID(401), false, true, faction
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
              loadPlayer.NamePlayer, loadPlayer.ClassPlayer, loadPlayer.RacePlayer, loadPlayer.HpCurrent, loadPlayer.HpMax, 
              loadPlayer.Gold, loadPlayer.Equipt, loadPlayer.IsDead, loadPlayer.Attackable, loadPlayer.Factions
            );
        }
        #endregion
    }
}

           

