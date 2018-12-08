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
            WorldListBuilder.Generate();
            GameTitle.Title();
            Console.WriteLine("");
            LocationCurrent.CurrentLocation();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Type help to see list of commands");
            Console.Write("> ");

            while (true)
            {
                //bool exit = false;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("< " + Player._player.NamePlayer +"-"+ Player._player.ClassPlayer + " > <" + Player._player.HpCurrent + "/" + Player._player.HpMax + " HP" + " >");
                Console.Write("> ");
                string inputUser = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputUser))
                {
                    continue;
                }

                string lowerInput = inputUser.ToLower();
                Console.WriteLine(" ");

                if (lowerInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saving character, will close when finished!");
                    //SaveData.SaveGameData(Player._player);
                    break;
                }

                ParseInput(lowerInput);
            }
        }

        private static void ParseInput(string input)
        {
            // Call the command class to figure out what to do.
            UserCommands.CommandCase(input, Player._player);

            // Write a blank line, to keep the UI a little cleaner
            Console.WriteLine("");
        }
    }
}

//exit = MenuList.MenuCommand(lowerInput);
//if (lowerInput == "exit")
//{
//      break;
//}