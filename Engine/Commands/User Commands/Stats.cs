using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Stats
    {
        public static void info(Player _player)
        {
            Console.WriteLine("Player Name: " + _player.NamePlayer);
            Console.WriteLine("Player Class: " + _player.ClassPlayer);
            Console.WriteLine("Player Race: " + _player.RacePlayer);
            Console.WriteLine("Player Race: " + _player.Armor);
            Console.WriteLine("Current hit points: {0}", _player.HpCurrent);
            Console.WriteLine("Maximum hit points: {0}", _player.HpMax);
            Console.WriteLine("Experience Points: {0}", _player.XP);
            Console.WriteLine("Level: {0}", _player.Level);
            Console.WriteLine("Gold: {0}", _player.Gold);
        }
    }
}
