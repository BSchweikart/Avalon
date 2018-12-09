using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Look
    {
        public static void Looking(string noun)
        {
            string CapNoun = CapWords.FirstCharToUpper(noun);
            determineVerbType(CapNoun);
        }

        public static void Looking()
        {
            LocationCurrent.CurrentLocation();
        }
        public static void determineVerbType(string noun)
        {
            Item itemToLook = WorldGenerator.ItemByName(noun);
            Weapon weaponToLook = WorldGenerator.WeaponByName(noun);
            Monster monsterToLook = WorldGenerator.MonsterByName(noun);
            NPC NpcToLook = WorldGenerator.NPCByName(noun);

            if (itemToLook != null)
            {
                foreach (Inventory item in Player._player.Inventory.ToList())
                {
                    if (item.Details.Name == itemToLook.ToString())
                    {
                        LookAtItem(item);
                    }
                }

                foreach (Item rmItem in Player.CurrentLocation.ItemRoom.ToList())
                {
                    if (rmItem.Name == itemToLook.Name)
                    {
                        LookAtItem(rmItem);
                    }
                }
            }
            else if (weaponToLook != null)
            {
                foreach (Inventory weapon in Player._player.Inventory.ToList())
                {
                    if (weapon.Details.Name == weaponToLook.Name)
                    {
                        LookAtWeapon(weapon);
                    }
                }

                foreach (Weapon rmWeapon in Player.CurrentLocation.ItemRoom.ToList())
                {
                    if (rmWeapon.Name == weaponToLook.Name)
                    {
                        LookAtWeapon(rmWeapon);
                    }
                }

            }
            else if (monsterToLook != null)
            {
                foreach (Monster mob in Player.CurrentLocation.MonsterRoom.ToList())
                {
                    if (mob.Name == monsterToLook.Name)
                    {
                        LookAtMonster(mob);
                    }
                }
            }
        }
        public static void LookAtItem(Inventory itemToLook)
        {
            Console.WriteLine("Item Name: " + itemToLook.Details);
            Console.WriteLine("Description: " + itemToLook.Details);
            Console.WriteLine("Item Price: " + itemToLook.Price);
        }
        public static void LookAtItem(Item itemToLook)
        {
            Console.WriteLine("Item Name: " + itemToLook.Name);
            Console.WriteLine("Description: " + itemToLook.Description);
            Console.WriteLine("Item Price: " + itemToLook.Price);
        }
        public static void LookAtWeapon(Inventory weaponToLook)
        {
            Console.WriteLine("Weapon Name: " + weaponToLook.WeaponName);
            Console.WriteLine("Description: " + weaponToLook.WeaponDesc);
            Console.WriteLine("Damage: " + weaponToLook.WeaponDamage);
            Console.WriteLine("Damage Type", weaponToLook.WeaponDamageType);
            Console.WriteLine("Price: ", weaponToLook.WeaponPrice.ToString());
        }
        public static void LookAtWeapon(Weapon weaponToLook)
        {
            Console.WriteLine("Weapon Name: " + weaponToLook.Name);
            Console.WriteLine("Description: " + weaponToLook.Description);
            Console.WriteLine("Damage: " + weaponToLook.DamageMax);
            Console.WriteLine("Damage Type", weaponToLook.DamageType);
            Console.WriteLine("Price: ", weaponToLook.Price.ToString());
        }
        public static void LookAtMonster(Monster monsterToLook)
        {
            Console.WriteLine("Name: " + monsterToLook.Name);
            //Console.WriteLine("Armor Class: " + monsterToLook.AC);
            Console.WriteLine("Current Hitpoints: " + monsterToLook.HpCurrent);
        }
        //public static void LookAtNpc(NPC npcToLook)
        //{
        //    Console.WriteLine("Name: " + npcToLook.NPCName);
        //    Console.WriteLine("Class: " + npcToLook.NPCClass);
        //    Console.WriteLine("Race: " + npcToLook.NPCRace);
        //}
    }
}
