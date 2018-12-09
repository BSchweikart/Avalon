using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace Engine
{
    class LoadPlayer
    {
        private static Weapon Equipt;

        //public static object World { get; private set; }

        public static void LoadGame(string name)
        {
            if (!File.Exists(name + ".xml"))
            {
                Console.WriteLine("Player does not exist.");
                IsNewPlayer.NewPlayer();
            }
            else
            {
                Player._player = null;
                Player._player = CreatePlayerFromXmlString(File.ReadAllText(name + ".xml"));
            }
        }

        public static Player CreatePlayerFromXmlString(string PLAYER_DATA_FILE_NAME)
        {
            try
            {
                XmlDocument playerData = new XmlDocument();

                playerData.LoadXml(PLAYER_DATA_FILE_NAME);
                string playerName = playerData.SelectSingleNode("/Player/Stats/Name").InnerText;
                string classPlayer = playerData.SelectSingleNode("/Player/Stats/Class").InnerText;
                string racePlayer = playerData.SelectSingleNode("/Player/Stats/Race").InnerText;
                int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
                int xp = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/XP").InnerText);
                int level = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Level").InnerText);
                int hpCurrent = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/HpCurrent").InnerText);
                int hpMax = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/HpMax").InnerText);
                int armor = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Armor").InnerText);
                Faction factionString = (Faction)Enum.Parse(typeof(Faction), (playerData.SelectSingleNode("/Player/Stats/Faction").InnerText), true);
                int equiptString = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);//check later
                Player player = new Player(playerName, classPlayer, racePlayer, gold, xp, armor, level, Equipt, hpCurrent, hpMax, false, true, factionString);
                int currentLocationID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText);
                Player.CurrentLocation = WorldGenerator.RoomByID(currentLocationID);

                if (playerData.SelectSingleNode("/Player/Stats/CurrentWeapon") != null)
                {
                    int currentWeaponID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
                    player.Equipt = WorldGenerator.WeaponByID(currentWeaponID);
                }

                foreach (XmlNode node in playerData.SelectNodes("/Player/Inventory/Inventory"))
                {
                    int id = Convert.ToInt32(node.Attributes["ID"].Value);
                    int quantity = Convert.ToInt32(node.Attributes["Quantity"].Value);

                    if (id > 100 && id <= 200)
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            player.AddItemToInventory(WorldGenerator.WeaponByID(id));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            player.AddItemToInventory(WorldGenerator.ItemByID(id));
                        }
                    }
                }
                return player;
            }
            catch
            {
                //Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}