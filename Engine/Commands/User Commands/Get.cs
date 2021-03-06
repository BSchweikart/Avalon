﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Get //Need to add Pots and Tres
    {
        public static void GetCommand(string verb, Player _player)
        {
            if (string.IsNullOrEmpty(verb))
            {
                Console.WriteLine("You must enter the name of the item to get");
            }
            else
            {
                if (verb != null)
                {
                    foreach (Item item in Player.CurrentLocation.ItemRoom.ToList())
                    {
                        if (item.Name.ToLower() == verb)
                        {
                            if (item.ID > 300 && item.ID <= 399)
                            {
                                _player.Inventory.Add(new Inventory(item, 1));
                                Player.CurrentLocation.ItemRoom.Remove(item);
                            }
                            else if (item.ID >= 400 && item.ID <= 499)
                            {
                                Weapon weaponToGet =
                                    WorldGenerator.weapons.SingleOrDefault(x => x.ID == item.ID);

                                _player.Inventory.Add(new Inventory(new Weapon(weaponToGet.ID, weaponToGet.Name, weaponToGet.Description, weaponToGet.Equiptable, weaponToGet.Price, weaponToGet.DamageMax), 1));
                                Player.CurrentLocation.ItemRoom.Remove(item);
                            }
                        }
                    }
                }
            }
        }
    }
}