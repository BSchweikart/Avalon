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

        public static object World { get; private set; }

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
                string PC = playerData.SelectSingleNode("/Player/Stats/Class").InnerText;
                string PR = playerData.SelectSingleNode("/Player/Stats/Race").InnerText;
                int currentHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentHitPoints").InnerText);
                int maximumHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumHitPoints").InnerText);
                int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
                int experiencePoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ExperiencePoints").InnerText);
                int alignment = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Alignment").InnerText);
                int equiptString = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
                Player player = new Player(playerName, PC, PR, gold, currentHitPoints, maximumHitPoints, equipt, false, true, alignment);
                int currentLocationID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText);

            }
        }
    }
}