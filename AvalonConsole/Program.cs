using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Engine;
using System.ComponentModel;

namespace AvalonConsole
{
    public class Program  // setting up new section to house items from the main
    {

        static void Main(string[] args)
        {
            WorldListBuilder.Generate();
            GameTitle.Title();
            //LocationCurrent.CurrentLocation();
            Console.WriteLine("");

            while (true)
            {
                // Wait for the user to type something, and press the <Enter> key
                string userInput = Console.ReadLine();

                // If they typed a blank line, loop back and wait for input again
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    continue;
                }

                // Convert to lower-case, to make comparisons easier
                string cleanedInput = userInput.ToLower();

                // Save the current game data, and break out of the "while(true)" loop
                if (cleanedInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saving character, will close when finished!");
                    //SaveData.SaveGameData(Player._player);
                    break;
                }

                // If the user typed something, try to determine what to do
                //ParseInput(cleanedInput);
            }




        }

        private static void Player_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CurrentLocation")
            {
                LocationCurrent.CurrentLocation();
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
            
        

