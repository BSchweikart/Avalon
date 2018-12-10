using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Engine;

namespace Avalon
{
    public class Program
    {
        private static void Main(string[] args)
        {
            #region Build World, Player
            WorldListBuilder.Generate();
            GameTitle.Title();
            Console.WriteLine("");
            LocationCurrent.CurrentLocation();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type help to see list of commands");
            Console.Write("> ");
            #endregion

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("< " + Player._player.NamePlayer +"-"+ Player._player.ClassPlayer + " > <" + Player._player.HpCurrent + "/" +  Player._player.HpMax + " HP" + " >");
                Console.Write("> ");
                string inputUser = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputUser))
                {
                    continue;
                }

                string lowerInput = inputUser.ToLower();
                Console.WriteLine(" ");

                if (lowerInput == "exit") //upon exit save player data
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saving character");
                    SavePlayerData.SaveGameData(Player._player);
                    break;
                }

                ParseInput(lowerInput);
            }
        }

        private static void ParseInput(string input)
        {
            UserCommands.CommandCase(input, Player._player);
        }
    }
}