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
            Treasure treasureToLook = WorldGenerator.TreasureByName(noun); //Not used
            Weapon weaponToLook = WorldGenerator.WeaponByName(noun);
            Monster monsterToLook = WorldGenerator.MonsterByName(noun);
            NPC NpcToLook = WorldGenerator.NPCByName(noun);

            #region Treasure - not used
            if (treasureToLook != null)
            {
                foreach (Inventory treasures in Player._player.Inventory.ToList())
                {
                    if (treasures.Details.Name == treasureToLook.ToString())
                    {
                        LookAtTreasure(treasures);
                    }
                }

                foreach (Treasure trItem in Player.CurrentLocation.ItemRoom.ToList())
                {
                    if (trItem.Name == treasureToLook.Name)
                    {
                        LookAtTreasure(trItem);
                    }
                }
            }
            #endregion

            #region Weapon 
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
            #endregion

            #region Monster
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
            #endregion

            #region NPC
            else if (NpcToLook != null)
            {
                foreach (NPC npc in Player.CurrentLocation.NPCRoom.ToList())
                {
                    if (npc.Name == NpcToLook.Name)
                    {
                        LookAtNpc(npc);
                    }
                }
            }
            #endregion
        }

        #region Treasure Detail - not used
        public static void LookAtTreasure(Inventory treasureToLook)
        {
            Console.WriteLine("Treasure Name: " + treasureToLook.Details);
            Console.WriteLine("Description: " + treasureToLook.Details);
            Console.WriteLine("Treasure Price: " + treasureToLook.Price);
        }
        public static void LookAtTreasure(Item treasureToLook)
        {
            Console.WriteLine("Treasure Name: " + treasureToLook.Name);
            Console.WriteLine("Description: " + treasureToLook.Description);
            Console.WriteLine("Treasure Price: " + treasureToLook.Price);
        }
        #endregion

        #region Weapons Detail
        public static void LookAtWeapon(Inventory weaponToLook)
        {
            Console.WriteLine("Weapon Name: " + weaponToLook.WeaponName);
            Console.WriteLine("Description: " + weaponToLook.WeaponDesc);
            Console.WriteLine("Damage: " + weaponToLook.WeaponDamage);
            Console.WriteLine("Price: ", weaponToLook.WeaponPrice.ToString());
        }
        public static void LookAtWeapon(Weapon weaponToLook)
        {
            Console.WriteLine("Weapon Name: " + weaponToLook.Name);
            Console.WriteLine("Description: " + weaponToLook.Description);
            Console.WriteLine("Damage: " + weaponToLook.DamageMax);
            Console.WriteLine("Price: ", weaponToLook.Price.ToString());
        }
        #endregion

        #region Monster Detail
        public static void LookAtMonster(Monster monsterToLook)
        {
            Console.WriteLine("Name: " + monsterToLook.Name);
            //Console.WriteLine(monsterToLook.Description);
            Console.WriteLine("Attack: " + monsterToLook.DamageMax);
            Console.WriteLine("Armor: " + monsterToLook.Armor);
            Console.WriteLine("Current Hitpoints: " + monsterToLook.HpCurrent);
        }
        #endregion

        #region NPC Detail
        public static void LookAtNpc(NPC npcToLook)
        {
            Console.WriteLine("Name: " + npcToLook.Name);
            Console.WriteLine(npcToLook.Descrip);
            Console.WriteLine("Health: " + npcToLook.HpMax);
        }
        #endregion
    }
}
