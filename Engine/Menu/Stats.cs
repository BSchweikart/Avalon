using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Stats // Can add more information at a later date
    {
        public static void info(Player _player)
        {
            Console.WriteLine("Player Name: " + _player.NamePlayer);
            Console.WriteLine("Level: {0}", _player.Level);
            Console.WriteLine("Experience Points: {0}", _player.XP);
            Console.WriteLine("Player Class: " + _player.ClassPlayer);
            Console.WriteLine("Player Race: " + _player.RacePlayer);
            Console.WriteLine("Current hit points: {0}", _player.HpCurrent);
            Console.WriteLine("Maximum hit points: {0}", _player.HpMax);
            Console.WriteLine("Player Armor: " + _player.Armor);
            Console.WriteLine("Weapon Name: " + _player.Equipt.Name);
            Console.WriteLine("Weapon Damage: " + _player.Equipt.DamageMax);
            Console.WriteLine("Gold: {0}", _player.Gold);
        }
    }
}
