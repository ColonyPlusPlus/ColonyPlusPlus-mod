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
            string cid = Managers.WorldManager.chunkName(Managers.WorldManager.positionToVector3Int(player.Position).ToChunk());
            
            // playerdata exists!
            PlayerData pd = getPlayerData(player, cid);

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
        }

        /// <summary>
        /// Get the player data for player.
        /// If player does not exist in our storage, it creates it with chunk id cid.
        /// </summary>
        /// <param name="player">The player to get the storage of.</param>
        /// <param name="cid">Optional. The chunk to start the player in. Default is ""</param>
        /// <returns>The PlayerData of player.</returns>
        private static PlayerData getPlayerData(Players.Player player, string cid="")
        {
            if (playerDataDict.ContainsKey(player.ID))
            {
                return playerDataDict[player.ID];
            }

            PlayerData pd = new PlayerData(player.ID, cid);

            playerDataDict.Add(player.ID, pd);

            Utilities.WriteLog("Player added:" + player.ID.steamID);

            return pd;
        }

        public static void notifyTrade(Players.Player from, Players.Player to, ushort give, int giveamt, ushort take, int takeamt)
        {
            PlayerData fromPd = getPlayerData(from);
            PlayerData toPd = getPlayerData(to);

            if (fromPd.tradeData != null || toPd.tradeData != null)
            {
                Chat.Send(from.ID, "Trade to " + to.Name + " failed, you or your trade partner have an outstanding trade.");
                Chat.Send(to.ID, "Trade from " + from.Name + " failed, you or your trade partner have an outstanding trade.");
                return;
            }
            string name;
            bool legalIds = ItemTypes.IndexLookup.TryGetName(give, out name );
            legalIds = legalIds && ItemTypes.IndexLookup.TryGetName(take, out name);

            if (!legalIds)
            {
                Chat.Send(from.ID, "Invalid ID's");
                return;
            }

            Stockpile fromSP = Stockpile.GetStockPile(fromPd.PID);
            Stockpile toSP = Stockpile.GetStockPile(toPd.PID);

            if (fromSP.AmountContained(take) <= takeamt)
            {
                Chat.Send(from.ID, "You can't afford that trade.");
                return;
            }

            fromPd.tradeData = new TradeData(give, giveamt, take, takeamt, ref toPd, true);
            toPd.tradeData = new TradeData(take, takeamt, give, giveamt, ref fromPd, false);

            Chat.Send(from.ID, "Trade sent to " + to.Name + ":");
            Chat.Send(from.ID, fromPd.tradeData.ToString() + " from " + to.Name);
            Chat.Send(from.ID, "Type '/trade reject' to cancel your trade.");
            Chat.Send(to.ID, "Incoming trade request:");
            Chat.Send(to.ID, toPd.tradeData.ToString() + " from " + from.Name);
            Chat.Send(to.ID, "Type '/trade accept' to accept the trade.");
            Chat.Send(to.ID, "Type '/trade reject' to reject the trade.");

            playerDataDict[from.ID] = fromPd;
            playerDataDict[to.ID] = toPd;
        }

        public static void acceptTrade(Players.Player player)
        {
            PlayerData pd = getPlayerData(player);

            if (pd.tradeData == null)
            {
                Chat.Send(player.ID, "You have no outstanding trade requests.");
                return;
            }

            PlayerData partnerData = pd.tradeData.partner;

            Stockpile playerStockpile = Stockpile.GetStockPile(player.ID);
            Stockpile partnerStockpile;
            Stockpile.TryGetStockpile(partnerData.PID, out partnerStockpile);

            if (partnerStockpile != null)
            {
                if (partnerStockpile.AmountContained(pd.tradeData.takeId) <= pd.tradeData.takeAmount)
                {
                    Chat.Send(player.ID, "You can't afford this trade. Please get the required items or reject the trade.");
                    return;
                }
                playerStockpile.Remove(pd.tradeData.takeId, pd.tradeData.takeAmount);
                partnerStockpile.Remove(pd.tradeData.giveId, pd.tradeData.giveAmount);
                playerStockpile.Add(pd.tradeData.giveId, pd.tradeData.giveAmount);
                partnerStockpile.Add(pd.tradeData.takeId, pd.tradeData.takeAmount);
            } else
            {
                Chat.Send(player.ID, "Your partner doesn't exist. Ignoring trade.");
                rejectTrade(player, true);
                return;
            }

            Chat.Send(player.ID, "Trade Accepted.");
            Chat.Send(partnerData.PID, player.Name + " accepted your trade request.");

            pd.tradeData = null;
            partnerData.tradeData = null;
            playerDataDict[player.ID] = pd;
            playerDataDict[partnerData.PID] = partnerData;
        }

        public static void rejectTrade(Players.Player player, bool isInternal = false)
        {

            PlayerData pd = getPlayerData(player);

            if (pd.tradeData == null)
            {
                Chat.Send(player.ID, "You have no outstanding trade requests.");
                return;
            }

            PlayerData partnerData = playerDataDict[pd.tradeData.partner.PID];

            if (!isInternal)
            {
                Chat.Send(player.ID, "Trade rejected.");
                Chat.Send(partnerData.PID, player.Name + " rejected your trade request.");
            }

            pd.tradeData = null;
            partnerData.tradeData = null;

            playerDataDict[pd.PID] = pd;
            playerDataDict[partnerData.PID] = partnerData;
        }

        public static void tradeGive(Players.Player from, Players.Player to, ushort give, int giveamt)
        {
            Stockpile playerStockpile = Stockpile.GetStockPile(from.ID);
            Stockpile partnerStockpile = Stockpile.GetStockPile(to.ID);

            string name;
            bool legalIds = ItemTypes.IndexLookup.TryGetName(give, out name);

            if (!legalIds)
            {
                Chat.Send(from.ID, "Invalid ID's");
                return;
            }

            if (playerStockpile.AmountContained(give) <= giveamt)
            {
                Chat.Send(from.ID, "You can't afford that.");
                return;
            }

            playerStockpile.Remove(give, giveamt);
            partnerStockpile.Add(give, giveamt);
            Chat.Send(from.ID, "You sent " + giveamt + " " + name + " to " + to.Name + ".");
            Chat.Send(to.ID, from.Name + " sent " + giveamt + " " + name + " to you.");
        }
    }
}
