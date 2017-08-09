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
                            Chat.Send(player, String.Format("You now in chunk owned by: {0}", Players.GetPlayer(WorldManager.ChunkDataList[cid].getOwner()).Name), ChatSenderType.Server);
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
            PlayerData fromPd = getPlayerData(from);
            PlayerData toPd = getPlayerData(to);

            if (fromPd.tradeData != null || toPd.tradeData != null)
            {
                Helpers.Chat.sendSilent(from, "Trade to " + to.Name + " failed, you or your trade partner have an outstanding trade.", Helpers.Chat.ChatColour.orange);
                Helpers.Chat.sendSilent(to, "Trade from " + from.Name + " failed, you or your trade partner have an outstanding trade.", Helpers.Chat.ChatColour.orange);
                return;
            }
            string name;
            bool legalIds = ItemTypes.IndexLookup.TryGetName(give, out name );
            legalIds = legalIds && ItemTypes.IndexLookup.TryGetName(take, out name);

            if (!legalIds)
            {
                Helpers.Chat.sendSilent(from, "Invalid ID's", Helpers.Chat.ChatColour.orange);
                return;
            }

            Stockpile fromSP = Stockpile.GetStockPile(from);
            Stockpile toSP = Stockpile.GetStockPile(to);

            if (fromSP.AmountContained(take) <= takeamt)
            {
                Helpers.Chat.sendSilent(from, "You can't afford that trade.", Helpers.Chat.ChatColour.orange);
                return;
            }

            fromPd.tradeData = new TradeData(give, giveamt, take, takeamt, ref toPd, true);
            toPd.tradeData = new TradeData(take, takeamt, give, giveamt, ref fromPd, false);

            Helpers.Chat.sendSilent(from, "Trade sent to " + to.Name + ":", Helpers.Chat.ChatColour.orange);
            Helpers.Chat.sendSilent(from, fromPd.tradeData.ToString() + " from " + to.Name, Helpers.Chat.ChatColour.orange);
            Helpers.Chat.sendSilent(from, "Type '/trade reject' to cancel your trade.", Helpers.Chat.ChatColour.orange);
            Helpers.Chat.sendSilent(to, "Incoming trade request:", Helpers.Chat.ChatColour.orange);
            Helpers.Chat.sendSilent(to, toPd.tradeData.ToString() + " from " + from.Name, Helpers.Chat.ChatColour.orange);
            Helpers.Chat.sendSilent(to, "Type '/trade accept' to accept the trade.", Helpers.Chat.ChatColour.orange);
            Helpers.Chat.sendSilent(to, "Type '/trade reject' to reject the trade.", Helpers.Chat.ChatColour.orange);

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
            PlayerData pd = getPlayerData(player);

            if (pd.tradeData == null)
            {
                Helpers.Chat.sendSilent(Players.GetPlayer(player.ID), "You have no outstanding trade requests.", Helpers.Chat.ChatColour.orange);
                return;
            }

            PlayerData partnerData = pd.tradeData.partner;

            Stockpile playerStockpile = Stockpile.GetStockPile(Players.GetPlayer(player.ID));
            Stockpile partnerStockpile;
            Stockpile.TryGetStockpile(Players.GetPlayer(partnerData.PID), out partnerStockpile);

            if (partnerStockpile != null)
            {
                if (partnerStockpile.AmountContained(pd.tradeData.giveId) <= pd.tradeData.giveAmount)
                {
                    Helpers.Chat.sendSilent(player, "Your partner can't afford this trade. It will need to be remade.", Helpers.Chat.ChatColour.orange);
                    Helpers.Chat.sendSilent(Players.GetPlayer(partnerData.PID), "You can't afford your trade with " + player.Name + ". Please get the required items and send another request.", Helpers.Chat.ChatColour.orange);
                    rejectTrade(player, true);
                    return;
                }

                if (playerStockpile.AmountContained(pd.tradeData.takeId) <= pd.tradeData.takeAmount)
                {
                    Helpers.Chat.sendSilent(player, "You can't afford this trade. Please get the required items or reject the trade.", Helpers.Chat.ChatColour.orange);
                    return;
                }

                playerStockpile.Remove(pd.tradeData.takeId, pd.tradeData.takeAmount);
                partnerStockpile.Remove(pd.tradeData.giveId, pd.tradeData.giveAmount);
                playerStockpile.Add(pd.tradeData.giveId, pd.tradeData.giveAmount);
                partnerStockpile.Add(pd.tradeData.takeId, pd.tradeData.takeAmount);
            } else
            {
                Helpers.Chat.sendSilent(player, "Your partner doesn't exist. Ignoring trade.", Helpers.Chat.ChatColour.orange);
                rejectTrade(player, true);
                return;
            }

            Helpers.Chat.sendSilent(player, "Trade Accepted.", Helpers.Chat.ChatColour.lime);
            Helpers.Chat.sendSilent(Players.GetPlayer(partnerData.PID), player.Name + " accepted your trade request.", Helpers.Chat.ChatColour.lime);

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
                PlayerData pd = getPlayerData(player);

                if (pd.tradeData == null)
                {
                    Helpers.Chat.sendSilent(player, "You have no outstanding trade requests.", Helpers.Chat.ChatColour.orange);
                    return;
                }

                PlayerData partnerData = playerDataDict[pd.tradeData.partner.PID];

                if (!isInternal)
                {
                    Helpers.Chat.sendSilent(player, "Trade rejected.", Helpers.Chat.ChatColour.orange);
                    Helpers.Chat.sendSilent(Players.GetPlayer(partnerData.PID), player.Name + " rejected your trade request.", Helpers.Chat.ChatColour.orange);
                }

                pd.tradeData = null;
                partnerData.tradeData = null;

                playerDataDict[pd.PID] = pd;
                playerDataDict[partnerData.PID] = partnerData;
            }
            else
            {
                Helpers.Chat.sendSilent(player, "Trade Disabled.", Helpers.Chat.ChatColour.red);
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
                    Helpers.Chat.sendSilent(from, "Invalid ID's", Helpers.Chat.ChatColour.orange);
                    return;
                }

                if (playerStockpile.AmountContained(give) <= giveamt)
                {
                    Helpers.Chat.sendSilent(from, "You can't afford that.", Helpers.Chat.ChatColour.orange);
                    return;
                }

                playerStockpile.Remove(give, giveamt);
                partnerStockpile.Add(give, giveamt);
                Helpers.Chat.sendSilent(from, "You sent " + giveamt + " " + name + " to " + to.Name + ".", Helpers.Chat.ChatColour.orange);
                Helpers.Chat.sendSilent(to, from.Name + " sent " + giveamt + " " + name + " to you.", Helpers.Chat.ChatColour.orange);
            }
            else
            {
                Helpers.Chat.sendSilent(from, "Trade Disabled.", Helpers.Chat.ChatColour.red);
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
                    Helpers.Chat.sendSilent(player, "Invalid ID's", Helpers.Chat.ChatColour.orange);
                    return;
                }

                int stockPileAmount = playerStockpile.AmountContained(item);
                if (stockPileAmount <= amount)
                {
                    Helpers.Chat.sendSilent(player, "You have less than " + amount +", trashing all.", Helpers.Chat.ChatColour.orange);
                    amount = stockPileAmount;
                }

                playerStockpile.Remove(item, amount);
                Helpers.Chat.sendSilent(player, String.Format("{0} of item [{1}] trashed.", amount, name), Helpers.Chat.ChatColour.orange);
            }
            else
            {
                Helpers.Chat.sendSilent(player, "Trashing Failed.", Helpers.Chat.ChatColour.red);
            }

        }

        public static bool getTradeEnabled()
        {
            return Classes.Managers.ConfigManager.getConfigBoolean("trade.enabled");
        }
    }
}
