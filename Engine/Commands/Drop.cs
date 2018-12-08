using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Drop
    {
        public static void Dropping(string verb, Player _player)
        {
           if (string.IsNullOrEmpty(verb))
                {
                    Console.WriteLine("You must enter the name of the item to drop");
                }
                else
                {
                    Item itemToDrop = WorldGenerator.items.SingleOrDefault(
                                       x => x.Name.ToLower() == verb);
                    Weapon weaponToDrop = WorldGenerator.weapons.SingleOrDefault(
                                       x => x.Name.ToLower() == verb);

                    foreach (Inventory item in Player._player.Inventory.ToList())
                    {
                        if (item.Details.Name.ToLower() == verb.ToString())
                        {
                            if (itemToDrop != null)
                            {
                                Player._player.RemoveItemFromInventory(itemToDrop, 1);
                                Player.CurrentLocation.ItemRoom.Add(itemToDrop);
                                Console.WriteLine("You drop {0}", verb);
                            }
                            else if (weaponToDrop != null)
                            {
                                Player._player.RemoveItemFromInventory(weaponToDrop, 1);
                                Player.CurrentLocation.ItemRoom.Add(weaponToDrop);
                                Console.WriteLine("You drop {0}", verb);
                            }
                        }
                        else if (item.Details.Name == null)
                        {
                            Console.WriteLine("You do not have the item {0}", verb);
                        }
                    }
                }
            }
        }
    }
