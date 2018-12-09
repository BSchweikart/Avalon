﻿using System;
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
            Faction faction = Faction.Admin;
            int gold = 0;
            int xp = 0;
            int armor = 0;
            int level = 1;
            Weapon equipt = null;
            int hpMax = 0;
            //int hpCurrent = 0;
            bool validClass = false;
            bool validRace = false;
            bool validFaction = false;

            Console.WriteLine("What is your name?");
            Console.Write(">");
            name = CapWords.FirstCharToUpper(Console.ReadLine());

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

            while (validFaction == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("To what faction do you belong?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Light, Dark > ");
                string strFaction = CapWords.FirstCharToUpper(Console.ReadLine());

                if (strFaction == Faction.Light.ToString() || strFaction == Faction.Dark.ToString() || strFaction == Faction.Admin.ToString())
                {
                    faction = (Faction)Enum.Parse(typeof(Faction), strFaction, true);
                    validFaction = true;

                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Player._player = new Player(name, CapWords.FirstCharToUpper(className), CapWords.FirstCharToUpper(raceName), gold, xp, armor, level, equipt, hpMax, hpMax, false, true, faction);
            Console.WriteLine("Loading game please wait");
            SavePlayerData.SaveGameData(Player._player);
        }
            public static void CreateFromLoad(Player loadPlayer)
            {
                Player _player = new Player(loadPlayer.NamePlayer, loadPlayer.ClassPlayer, loadPlayer.RacePlayer, loadPlayer.Gold, loadPlayer.XP, loadPlayer.Armor, loadPlayer.Level, loadPlayer.Equipt, loadPlayer.HpCurrent,
                                 loadPlayer.HpMax, loadPlayer.IsDead, loadPlayer.Attackable, loadPlayer.Factions);
            }
    }
}

           

