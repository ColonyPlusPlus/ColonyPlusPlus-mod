using System;
using System.Collections.Generic;
using Pipliz.Chatting;

namespace ColonyPlusPlusCore.Managers
{
    public static class PlayerManager
    {
        private static Dictionary<NetworkID, Data.PlayerData> playerDataDict = new Dictionary<NetworkID, Data.PlayerData>();
        


        

        /// <summary>
        /// Get the player data for player.
        /// If player does not exist in our storage, it creates it with chunk id cid.
        /// </summary>
        /// <param name="player">The player to get the storage of.</param>
        /// <param name="cid">Optional. The chunk to start the player in. Default is ""</param>
        /// <returns>The PlayerData of player.</returns>
        private static Data.PlayerData getPlayerData(Players.Player player, string cid="")
        {
            if (playerDataDict.ContainsKey(player.ID))
            {
                return playerDataDict[player.ID];
            }

            Data.PlayerData pd = new Data.PlayerData(player.ID, cid);

            playerDataDict.Add(player.ID, pd);

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Core", "Player added:" + player.ID.steamID);

            return pd;
        }
        
    }
}
