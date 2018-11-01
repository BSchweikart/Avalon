using System;
using System.IO;

// need to link everything in and have the selection clear after

namespace Avalon
{
    public class StartMenu
    {
        public static void LaunchMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Which direction would you like to move");
            Console.WriteLine("North" + " " + "South" + " " + "East" + " " + "West");
            Console.WriteLine("Attack");
            Console.WriteLine("Bags");
            Console.WriteLine("Use");
            Console.WriteLine("Exit");
        }
    }
}

//private static void userInput(string input)
//{
//    if (input.Contains("new game"))
//    {
//        Console.Clear();

//        Console.WriteLine("still working on");
//        Console.WriteLine("Press Enter or type Exit to back up");
//        Console.ReadLine();
//    }

//    else if (input.Contains("saved game"))
//    {
//        Console.Clear();
//        Console.WriteLine("still working on");
//        Console.WriteLine("Press Enter or type Exit to back up");
//        Console.ReadLine();
//    }
//    else if (input.Contains("menu"))
//    {
//        string line;
//        Console.Clear();
//        Console.WriteLine("Menu");
//        Console.WriteLine("Which document would you like to dispaly");
//        Console.WriteLine("");
//        Console.WriteLine("Help");
//        Console.WriteLine("Monsters");
//        Console.WriteLine("NPC");
//        Console.WriteLine("Races");
//        Console.WriteLine("Classes");
//        Console.WriteLine("Potions");
//        Console.WriteLine("Treasure");
//        Console.WriteLine("Weapons");
//        Console.WriteLine("Armor");
//        Console.WriteLine("Rooms");
//        Console.WriteLine("Press Enter or type Exit to back up");
//        Console.WriteLine("");
//        string userInput = Console.ReadLine();
//        string lowInput = userInput.ToLower();

//        if (lowInput == "monsters")
//        {
//            Console.Clear(); // Clear items on the Console
//            StreamReader creatureText = new StreamReader(@"../../.../Engine/Docs/Monster.txt"); // txt @ location set value         
//            line = creatureText.ReadToEnd(); // read the whole file and not by line set to line
//            Console.WriteLine(line); // Write the txt to the console               
//            creatureText.Close(); // Close the file
//            Console.Read(); // Read input
//            Console.Clear();// Clear items on the Console

//        }
//        else if (lowInput == "npc")
//        {
//            Console.Clear();
//            StreamReader npcText = new StreamReader(@"../../../Engine/Docs/NPC.txt"); // txt @ location set value              
//            line = npcText.ReadToEnd(); // read the whole file and not by line set to line
//            Console.WriteLine(line);
//            npcText.Close();
//            Console.Read();
//            Console.Clear();// Clear items on the Console
//        }
//        else if (lowInput == "races")
//        {
//            Console.Clear();
//            StreamReader racesText = new StreamReader(@"../../../Engine/Docs/Races.txt"); // txt @ location set value              
//            line = racesText.ReadToEnd(); // read the whole file and not by line set to line
//            Console.WriteLine(line);
//            racesText.Close();
//            Console.Read();
//            Console.Clear();// Clear items on the Console
//        }
//        else if (lowInput == "classes")
//        {
//            Console.Clear();
//            StreamReader classesText = new StreamReader(@"../../../Engine/Docs/Classes.txt"); // txt @ location set value              
//            line = classesText.ReadToEnd(); // read the whole file and not by line set to line
//            Console.WriteLine(line);
//            classesText.Close();
//            Console.Read();
//            Console.Clear();// Clear items on the Console
//        }
//        else if (lowInput == "potions")
//        {
//            Console.Clear();
//            StreamReader potionsText = new StreamReader(@"../../../Engine/Docs/potions.txt"); // txt @ location set value              
//            line = potionsText.ReadToEnd(); // read the whole file and not by line set to line
//            Console.WriteLine(line);
//            potionsText.Close();
//            Console.Read();
//            Console.Clear();// Clear items on the Console
//        }
//        else if (lowInput == "treasure")
//        {
//            Console.Clear();
//            StreamReader treasureText = new StreamReader(@"../../../Engine/Docs/Treasure.txt"); // txt @ location set value              
//            line = treasureText.ReadToEnd(); // read the whole file and not by line set to line
//            Console.WriteLine(line);
//            treasureText.Close();
//            Console.Read();
//            Console.Clear();// Clear items on the Console
//        }
//        else if (lowInput == "weapons")
//        {
//            Console.Clear();
//            StreamReader weaponsText = new StreamReader(@"../../../Engine/Docs/Weapons.txt"); // txt @ location set value             
//            line = weaponsText.ReadToEnd(); // read the whole file and not by line set to line
//            Console.WriteLine(line);
//            weaponsText.Close();
//            Console.Read();
//            Console.Clear();// Clear items on the Console
//        }
//        else if (lowInput == "armor")
//        {
//            Console.Clear();
//            Console.WriteLine("I really am sorry but this section is under works");
//            Console.WriteLine("Fear not, for you shall not be naked for long!");
//            Console.WriteLine("This we do swear");
//            Console.WriteLine("Your Avalon Dev Team");
//            //StreamReader armorText = new StreamReader(@"../../../Core/Docs/Armor.txt"); // txt @ location set value          
//            //line = armorText.ReadToEnd(); // read the whole file and not by line set to line
//            //Console.WriteLine(line);              
//            //armorText.Close();
//            Console.Read();
//            Console.Clear();// Clear items on the Console
//        }
//        else if (lowInput == "rooms")
//        {
//            Console.Clear();
//            StreamReader creatureText = new StreamReader(@"../../../Engine/Docs/Rooms.txt");  // txt @ location set value            
//            line = creatureText.ReadToEnd(); // read the whole file and not by line set to line
//            Console.WriteLine(line);
//            creatureText.Close();
//            Console.Read();
//            Console.Clear();// Clear items on the Console
//        }

//    }

//}


//Console.WriteLine("Welcome to Avalon");
//            Console.WriteLine("Please type in your selection followed by Enter");
//            Console.WriteLine("");
//            Console.WriteLine("New Game");
//            Console.WriteLine("Saved Game");
//            Console.WriteLine("Menu");
//            Console.WriteLine("Exit");
//            Console.WriteLine("");