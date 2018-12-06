﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine
{
    public static class SavePlayerData
    {
        public static string PLAYER_DATA_FILE_NAME = (CapWords.FirstCharToUpper(Player._player.playerName) + ".xml");

        public static void SaveGameData(Player _player)
        {
            File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());
        }
    }
}
