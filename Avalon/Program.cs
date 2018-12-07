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
            Console.WriteLine("Type help to see list of commands");
            Console.Write("> ");

            while (true)
            {
                bool exit = false;
                Console.WriteLine("< " + Player._player.HpCurrent + "/" + Player._player.HpMax + " HP" + " >");
                Console.Write("> ");
                string inputUser = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputUser))
                {
                    continue;
                }

                string lowerInput = inputUser.ToLower();
                Console.WriteLine(" ");
                exit = MenuList.MenuCommand(lowerInput);

                if (lowerInput == "exit")
                {
                    break;
                }
            }
        }
    }
}