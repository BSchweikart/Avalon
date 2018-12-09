using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Equipt
    {
        public static void Equip(string noun, Player _player)
        {
            foreach (Inventory item in _player.Inventory.ToList())
            {
                if (item.Details.Name.ToLower() == noun.ToString())
                {
                    if (string.IsNullOrEmpty(noun))
                    {
                        Console.WriteLine("Enter the name of the weapon you want to equip");
                    }
                    else
                    {
                        Weapon weaponToEquip =
                            WorldGenerator.weapons.SingleOrDefault(
                                x => x.Name.ToLower() == noun);

                        if (weaponToEquip == null)
                        {
                            Console.WriteLine("You do not have the weapon: {0}", weaponToEquip);
                        }
                        else
                        {
                            _player.Inventory.Add(new Inventory(_player.Equipt, 1));
                            _player.Equipt = weaponToEquip;
                            _player.RemoveItemFromInventory(weaponToEquip, 1);
                            Console.WriteLine("You equip your {0}", weaponToEquip.Name.ToString());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That weapon is not in your inventory");
                }
            }
        }
    }
}
