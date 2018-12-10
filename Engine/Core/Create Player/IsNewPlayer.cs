using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class IsNewPlayer // Find out if New or Past Player
    {
        public static void NewPlayer()
        {
            //get the user input
            string usersInput;
            //always false until user adds input
            bool validAnswer = false;

            while (validAnswer == false)
            {
                Console.WriteLine("Are you new to Avalon?");
                Console.Write("> ");
                usersInput = Console.ReadLine();

                if (usersInput.ToLower() == "no") //Get save data info
                {
                    validAnswer = true;
                    Console.WriteLine("What is your name?");
                    usersInput = CapWords.FirstCharToUpper(Console.ReadLine());
                    LoadPlayer.LoadGame(usersInput.ToLower());
                }
                else if (usersInput.ToLower() == "yes") // Move on to create the player
                {
                    validAnswer = true;
                    CreatePlayer.CreateAPlayer();
                }
                else
                {
                    Console.WriteLine("Enter a valid answer.");
                }
            }
        }
    }

}
