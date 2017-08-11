using System;
using System.Collections.Generic;
using ColonyAPI.Helpers;

namespace ColonyPlusPlusUtilities.Managers
{
    public static class PlayerManager
    {
        private static Dictionary<NetworkID, Data.PlayerData> playerDataDict = new Dictionary<NetworkID, Data.PlayerData>();
        
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

            Data.PlayerData pd = getPlayerData(player, cid);

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
                            Chat.send(player, String.Format("You now in chunk owned by: {0}", Players.GetPlayer(WorldManager.ChunkDataList[cid].getOwner()).Name));
                        } else
                        {
                            //Chat.Send(player, "You own this chunk", ChatSenderType.Server);
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
        private static Data.PlayerData getPlayerData(Players.Player player, string cid="")
        {
            if (playerDataDict.ContainsKey(player.ID))
            {
                return playerDataDict[player.ID];
            }

            Data.PlayerData pd = new Data.PlayerData(player.ID, cid);

            playerDataDict.Add(player.ID, pd);

            Utilities.WriteLog("ColonyPlusPlusUtilities", "Player added:" + player.ID.steamID);

            return pd;
        }

        /// <summary>
        /// INTERNAL
        /// Notifies player to that there is a trade offer from from.
        /// If any of the arguments are invalid it will tell the users that they need to correct them.
        /// </summary>
        /// <param name="from">The player that is sending the request.</param>
        /// <param name="to">The player that is getting sent the request.</param>
        /// <param name="give">The ItemID of the item from is giving away.</param>
        /// <param name="giveamt">How many from is giving to to.</param>
        /// <param name="take">The ItemID of the item from wants from to.</param>
        /// <param name="takeamt">How many from wants from to.</param>
        public static void notifyTrade(Players.Player from, Players.Player to, ushort give, int giveamt, ushort take, int takeamt)
        {
            Data.PlayerData fromPd = getPlayerData(from);
            Data.PlayerData toPd = getPlayerData(to);

            if (fromPd.tradeData != null || toPd.tradeData != null)
            {
                Chat.sendSilent(from, "Trade to " + to.Name + " failed, you or your trade partner have an outstanding trade.", Chat.ChatColour.orange);
                Chat.sendSilent(to, "Trade from " + from.Name + " failed, you or your trade partner have an outstanding trade.", Chat.ChatColour.orange);
                return;
            }
            string name;
            bool legalIds = ItemTypes.IndexLookup.TryGetName(give, out name );
            legalIds = legalIds && ItemTypes.IndexLookup.TryGetName(take, out name);

            if (!legalIds)
            {
                Chat.sendSilent(from, "Invalid ID's", Chat.ChatColour.orange);
                return;
            }

            Stockpile fromSP = Stockpile.GetStockPile(from);
            Stockpile toSP = Stockpile.GetStockPile(to);

            if (fromSP.AmountContained(take) <= takeamt)
            {
                Chat.sendSilent(from, "You can't afford that trade.", Chat.ChatColour.orange);
                return;
            }

            fromPd.tradeData = new Data.TradeData(give, giveamt, take, takeamt, ref toPd, true);
            toPd.tradeData = new Data.TradeData(take, takeamt, give, giveamt, ref fromPd, false);

            Chat.sendSilent(from, "Trade sent to " + to.Name + ":", Chat.ChatColour.orange);
            Chat.sendSilent(from, fromPd.tradeData.ToString() + " from " + to.Name, Chat.ChatColour.orange);
            Chat.sendSilent(from, "Type '/trade reject' to cancel your trade.", Chat.ChatColour.orange);
            Chat.sendSilent(to, "Incoming trade request:", Chat.ChatColour.orange);
            Chat.sendSilent(to, toPd.tradeData.ToString() + " from " + from.Name, Chat.ChatColour.orange);
            Chat.sendSilent(to, "Type '/trade accept' to accept the trade.", Chat.ChatColour.orange);
            Chat.sendSilent(to, "Type '/trade reject' to reject the trade.", Chat.ChatColour.orange);

            playerDataDict[from.ID] = fromPd;
            playerDataDict[to.ID] = toPd;
        }

        /// <summary>
        /// INTERNAL
        /// Accepts the trade in player's current playerdata, set the items, and notify the users.
        /// </summary>
        /// <param name="player">The player who is accepting.</param>
        public static void acceptTrade(Players.Player player)
        {
            Data.PlayerData pd = getPlayerData(player);

            if (pd.tradeData == null)
            {
                Chat.sendSilent(Players.GetPlayer(player.ID), "You have no outstanding trade requests.", Chat.ChatColour.orange);
                return;
            }

            Data.PlayerData partnerData = pd.tradeData.partner;

            Stockpile playerStockpile = Stockpile.GetStockPile(Players.GetPlayer(player.ID));
            Stockpile partnerStockpile;
            Stockpile.TryGetStockpile(Players.GetPlayer(partnerData.PID), out partnerStockpile);

            if (partnerStockpile != null)
            {
                if (partnerStockpile.AmountContained(pd.tradeData.giveId) <= pd.tradeData.giveAmount)
                {
                    Chat.sendSilent(player, "Your partner can't afford this trade. It will need to be remade.", Chat.ChatColour.orange);
                    Chat.sendSilent(Players.GetPlayer(partnerData.PID), "You can't afford your trade with " + player.Name + ". Please get the required items and send another request.", Chat.ChatColour.orange);
                    rejectTrade(player, true);
                    return;
                }

                if (playerStockpile.AmountContained(pd.tradeData.takeId) <= pd.tradeData.takeAmount)
                {
                    Chat.sendSilent(player, "You can't afford this trade. Please get the required items or reject the trade.", Chat.ChatColour.orange);
                    return;
                }

                playerStockpile.Remove(pd.tradeData.takeId, pd.tradeData.takeAmount);
                partnerStockpile.Remove(pd.tradeData.giveId, pd.tradeData.giveAmount);
                playerStockpile.Add(pd.tradeData.giveId, pd.tradeData.giveAmount);
                partnerStockpile.Add(pd.tradeData.takeId, pd.tradeData.takeAmount);
            } else
            {
                Chat.sendSilent(player, "Your partner doesn't exist. Ignoring trade.", Chat.ChatColour.orange);
                rejectTrade(player, true);
                return;
            }

            Chat.sendSilent(player, "Trade Accepted.", Chat.ChatColour.lime);
            Chat.sendSilent(Players.GetPlayer(partnerData.PID), player.Name + " accepted your trade request.", Chat.ChatColour.lime);

            pd.tradeData = null;
            partnerData.tradeData = null;
            playerDataDict[player.ID] = pd;
            playerDataDict[partnerData.PID] = partnerData;
        }

        /// <summary>
        /// INTERNAL
        /// Rejects the trade in player's current playerdata and notifies the users.
        /// </summary>
        /// <param name="player">The player who is rejecting.</param>
        /// <param name="isInternal">If this was called internally. If true then it doesn't notify the users.</param>
        public static void rejectTrade(Players.Player player, bool isInternal = false)
        {
            if (getTradeEnabled())
            {
                Data.PlayerData pd = getPlayerData(player);

                if (pd.tradeData == null)
                {
                    Chat.sendSilent(player, "You have no outstanding trade requests.", Chat.ChatColour.orange);
                    return;
                }

                Data.PlayerData partnerData = playerDataDict[pd.tradeData.partner.PID];

                if (!isInternal)
                {
                    Chat.sendSilent(player, "Trade rejected.", Chat.ChatColour.orange);
                    Chat.sendSilent(Players.GetPlayer(partnerData.PID), player.Name + " rejected your trade request.", Chat.ChatColour.orange);
                }

                pd.tradeData = null;
                partnerData.tradeData = null;

                playerDataDict[pd.PID] = pd;
                playerDataDict[partnerData.PID] = partnerData;
            }
            else
            {
                Chat.sendSilent(player, "Trade Disabled.", Chat.ChatColour.red);
            }
        }

        /// <summary>
        /// INTERNAL
        /// From gives to items.
        /// </summary>
        /// <param name="from">The player sending the items.</param>
        /// <param name="to">The player recieving the items.</param>
        /// <param name="give">The ItemID of the item given.</param>
        /// <param name="giveamt">How many of the item given.</param>
        public static void tradeGive(Players.Player from, Players.Player to, ushort give, int giveamt)
        {
            if (getTradeEnabled())
            {

                Stockpile playerStockpile = Stockpile.GetStockPile(from);
                Stockpile partnerStockpile = Stockpile.GetStockPile(to);

                string name;
                bool legalIds = ItemTypes.IndexLookup.TryGetName(give, out name);

                if (!legalIds)
                {
                    Chat.sendSilent(from, "Invalid ID's", Chat.ChatColour.orange);
                    return;
                }

                if (playerStockpile.AmountContained(give) <= giveamt)
                {
                    Chat.sendSilent(from, "You can't afford that.", Chat.ChatColour.orange);
                    return;
                }

                playerStockpile.Remove(give, giveamt);
                partnerStockpile.Add(give, giveamt);
                Chat.sendSilent(from, "You sent " + giveamt + " " + name + " to " + to.Name + ".", Chat.ChatColour.orange);
                Chat.sendSilent(to, from.Name + " sent " + giveamt + " " + name + " to you.", Chat.ChatColour.orange);
            }
            else
            {
                Chat.sendSilent(from, "Trade Disabled.", Chat.ChatColour.red);
            }

        }


        /// <summary>
        /// INTERNAL
        /// Trashes items.
        /// </summary>
        /// <param name="item">The ItemID of the item given.</param>
        /// <param name="amount">How many of the item given.</param>
        public static void trashItems(Players.Player player, ushort item, int amount)
        {
            if (Permissions.PermissionsManager.CheckAndWarnPermission(player, "trash"))
            {

                Stockpile playerStockpile = Stockpile.GetStockPile(player);

                string name;
                bool legalIds = ItemTypes.IndexLookup.TryGetName(item, out name);

                if (!legalIds)
                {
                    Chat.sendSilent(player, "Invalid ID's", Chat.ChatColour.orange);
                    return;
                }

                int stockPileAmount = playerStockpile.AmountContained(item);
                if (stockPileAmount <= amount)
                {
                    Chat.sendSilent(player, "You have less than " + amount +", trashing all.", Chat.ChatColour.orange);
                    amount = stockPileAmount;
                }

                playerStockpile.Remove(item, amount);
                Chat.sendSilent(player, String.Format("{0} of item [{1}] trashed.", amount, name), Chat.ChatColour.orange);
            }
            else
            {
                Chat.sendSilent(player, "Trashing Failed.", Chat.ChatColour.red);
            }

        }

        public static bool getTradeEnabled()
        {
            return ColonyAPI.Managers.ConfigManager.getConfigBoolean("trade.enabled");
        }
    }
}
