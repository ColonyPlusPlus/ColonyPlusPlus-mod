using Pipliz.Collections.Threadsafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Data;
using Pipliz.Chatting;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class PlayerManager
    {
        private static Dictionary<NetworkID, Classes.Data.PlayerData> playerDataDict = new Dictionary<NetworkID, Classes.Data.PlayerData>();
        
        public static void notifyNewChunkEntrances()
        {
            // get the number of connected players
            int playerCount = Players.CountConnected;
            
            if(playerCount > 0)
            {
                for (int i = 0; i < playerCount; i++)
                {
                    notifyNewChunkEntrancesIterator(Players.GetConnectedByIndex(i));
                }
            }
           

        }

        /// <summary>
        /// Take this player, check if they've changed position, if so, tell them if the chunk belongs to anyone!
        /// </summary>
        /// <param name="player">player</param>
        private static void notifyNewChunkEntrancesIterator(Players.Player player)
        {
            
            // get the current chunkID
            string cid = Managers.WorldManager.positionToString(Managers.WorldManager.positionToVector3Int(player.Position).ToChunk());

            if (playerDataDict.ContainsKey(player.ID))
            {
                // playerdata exists!
                PlayerData pd = playerDataDict[player.ID];

                if(pd.chunkID == cid)
                {
                    // they haven't changed chunks yet

                } else
                {
                    // they have!
                    if(WorldManager.ChunkDataList.ContainsKey(cid))
                    {
                        if(WorldManager.ChunkDataList[cid].hasOwner())
                        {
                            if(WorldManager.ChunkDataList[cid].getOwner() != player.ID)
                            {
                                // we are in a foreign owned chunk!
                                Chat.Send(player.ID, String.Format("You now in chunk owned by: {0}", Players.GetPlayer(WorldManager.ChunkDataList[cid].getOwner()).Name), ChatSenderType.Server);
                            }
                        }
                    }

                    
                    //update the reference to the chunk they are in
                    pd.chunkID = cid;
                    
                }

            } else
            {
                // playerdata not yet set, set it!
                PlayerData pd = new PlayerData(player.ID, cid);

                playerDataDict.Add(player.ID, pd);

                Utilities.WriteLog("Player added:" + player.ID.steamID);

            }
        }
    }
}
