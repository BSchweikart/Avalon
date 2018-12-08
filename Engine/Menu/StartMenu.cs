using System;
using System.IO;

// need to link everything in and have the selection clear after

namespace Engine
{
    public class StartMenu
    {
        public static void LaunchMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Attack");
            Console.WriteLine("Bags");
            Console.WriteLine("Use");
            Console.WriteLine("Help");
            Console.WriteLine("Exit");
        }
    }
}