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
            //int aligment = 0;
            int gold = 0;
            int hp = 0;
            bool validClass = false;
            bool validRace = false;

            Console.WriteLine("What is your name?");
            Console.Write(">");
            name = CapWords.FirstCharToUpper(Console.ReadLine());

            while (validClass == false)
            {
                Console.WriteLine("Choose a class.");
                Console.WriteLine("Warrior, Archer, Healer, Assissin, or Mage");
                className = Console.ReadLine().ToLower();

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
                else if (className == "assissin")
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

            while (validRace == false)
            {
                Console.WriteLine("Choose a race.");
                Console.WriteLine("Elf, Dwarf, Gaint, Fairy, Dragon");
                raceName = Console.ReadLine().ToLower();

                if (raceName == "elf")
                {
                    validRace = true;
                    hp = 100;
                }
                else if (raceName == "dwarf")
                {
                    validRace = true;
                    hp = 100;
                }
                else if (raceName == "gaint")
                {
                    validRace = true;
                    hp = 100;
                }
                else if (raceName == "fairy")
                {
                    validRace = true;
                    hp = 100;
                }
                else if (raceName == "dragon")
                {
                    validRace = true;
                    hp = 100;
                }
                else
                {
                    Console.WriteLine("Pick a valid race");
                }
            }
        }
            public static void CreateFromLoad(Player loadPlayer)
            {
                Player _player = new Player(loadPlayer.NamePlayer, loadPlayer.ClassPlayer, loadPlayer.RacePlayer, loadPlayer.Gold, loadPlayer.XP, loadPlayer.Level, loadPlayer.Equipt, loadPlayer.HpCurrent,
                                 loadPlayer.HpMax, loadPlayer.IsDead, loadPlayer.Attackable);
            }
    }
}

           

