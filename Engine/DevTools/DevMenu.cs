using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;
using System.IO;

namespace Engine
{
    public class DevMenu
    {
        static int index = 0;
        public static void InterMenu()
        {

            List<string> menuItem = new List<string>() // Set Names for the display of the menu
            {
                "Monsters", "NPC", "Races", "Classes", "Potions",
                "Treasure", "Weapons", "Armor", "Rooms", "Player", "Level", "Exit"
            };

            String line;  // Set line to be read into string
            Console.CursorVisible = false; // Hide the Cursor
            while (true)
            {
                Console.WriteLine("Use Up and Down Arrow keys and Enter to make a selection");
                Console.WriteLine("After making a selection use Enter to return to the Main Menu");
                Console.WriteLine("Which selection would you like to display");
                string selectedMenuItem = drawMenu(menuItem); // Display the menu in the order listed
                if (selectedMenuItem == "Monsters")
                {
                    Console.Clear(); // Clear items on the Console
                    StreamReader creatureText = new StreamReader(@"../../.../Engine/Docs/Monster.txt"); // txt @ location set value         
                    line = creatureText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line); // Write the txt to the console               
                    creatureText.Close(); // Close the file
                    Console.Read(); // Read input
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "NPC")
                {
                    Console.Clear();
                    StreamReader npcText = new StreamReader(@"../../../Engine/Docs/NPC.txt"); // txt @ location set value              
                    line = npcText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    npcText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Races")
                {
                    Console.Clear();
                    StreamReader racesText = new StreamReader(@"../../../Engine/Docs/Races.txt"); // txt @ location set value              
                    line = racesText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    racesText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Classes")
                {
                    Console.Clear();
                    StreamReader classesText = new StreamReader(@"../../../Engine/Docs/Classes.txt"); // txt @ location set value              
                    line = classesText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    classesText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Potions")
                {
                    Console.Clear();
                    StreamReader potionsText = new StreamReader(@"../../../Engine/Docs/potions.txt"); // txt @ location set value              
                    line = potionsText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    potionsText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Treasure")
                {
                    Console.Clear();
                    StreamReader treasureText = new StreamReader(@"../../../Engine/Docs/Treasure.txt"); // txt @ location set value              
                    line = treasureText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    treasureText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Weapons")
                {
                    Console.Clear();
                    StreamReader weaponsText = new StreamReader(@"../../../Engine/Docs/Weapons.txt"); // txt @ location set value             
                    line = weaponsText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    weaponsText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Armor")
                {
                    Console.Clear();
                    Console.WriteLine("I really am sorry but this section is under works");
                    Console.WriteLine("Fear not, for you shall not be naked for long!");
                    Console.WriteLine("This we do swear");
                    Console.WriteLine("Your Avalon Dev Team");
                    //StreamReader armorText = new StreamReader(@"../../../Core/Docs/Armor.txt"); // txt @ location set value          
                    //line = armorText.ReadToEnd(); // read the whole file and not by line set to line
                    //Console.WriteLine(line);              
                    //armorText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Rooms")
                {
                    Console.Clear();
                    StreamReader creatureText = new StreamReader(@"../../../Engine/Docs/Rooms.txt");  // txt @ location set value            
                    line = creatureText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    creatureText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Player")
                {
                    Console.Clear();
                    StreamReader creatureText = new StreamReader(@"../../../Engine/Docs/Player.txt");  // txt @ location set value            
                    line = creatureText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    creatureText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Level")
                {
                    Console.Clear();
                    Console.WriteLine("Total amount of levels");
                    StreamReader creatureText = new StreamReader(@"../../../Engine/Docs/Level.txt");   // txt @ location set value           
                    line = creatureText.ReadToEnd(); // read the whole file and not by line set to line
                    Console.WriteLine(line);
                    creatureText.Close();
                    Console.Read();
                    Console.Clear();// Clear items on the Console
                }
                else if (selectedMenuItem == "Exit")
                {
                    Console.Clear();// Clear items on the Console
                    Console.WriteLine("Good Bye");
                    Console.Read();
                    Environment.Exit(0);
                }
                Console.Clear(); // Clear items on the Console after the exit
            }
        }

        private static string drawMenu(List<string> items) // used to draw the menu
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Gray; // set highlight color
                    Console.ForegroundColor = ConsoleColor.Black; // set menu color
                    Console.WriteLine(items[i]); // write the times from index
                }
                else
                {
                    Console.WriteLine(items[i]);
                }

                Console.ResetColor();

            }

            ConsoleKeyInfo ckey = Console.ReadKey(); // used to read key press

            if (ckey.Key == ConsoleKey.DownArrow) // used to understand down arrow
            {
                if (index == items.Count - 1)
                {
                    //index = 0;
                }

                else
                {
                    index++;
                }
            }
            else if (ckey.Key == ConsoleKey.UpArrow) // used to understand up arrow
            {
                if (index <= 0)
                {
                    //index = 0;
                }

                else
                {
                    index--;
                }
            }
            else if (ckey.Key == ConsoleKey.Enter) // used to understand enter
            {
                return items[index];
            }
            else
            {
                return "";
            }

            Console.Clear();
            return "";
        }
    }
}
