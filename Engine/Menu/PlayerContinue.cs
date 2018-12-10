using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Engine
{
    public class PlayerContinue //Used upon player death
    {
        public static void PContinue(Player player)
        {
            string usersInput;
            bool validAnswer = false;

            while (validAnswer == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are a weakling");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Would you like to Continue?");
                Console.WriteLine("Yes, No, or Create");
                Console.Write("> ");
                usersInput = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                if (usersInput.ToLower() == "no")
                {
                    Environment.Exit(0);
                }
                else if (usersInput.ToLower() == "yes")
                {
                    LocationCurrent.CurrentLocation();
                    break;
                }
                else if (usersInput.ToLower() == "create")
                {
                    Console.Clear(); // clear Console to keep clean
                    CreatePlayer.CreateAPlayer();
                    LocationCurrent.CurrentLocation();
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid answer.");
                }
            }
        }
    }
}
