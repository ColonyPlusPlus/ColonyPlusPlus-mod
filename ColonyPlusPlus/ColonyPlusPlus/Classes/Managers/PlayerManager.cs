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
                Chat.Send(from, "Trade to " + to.Name + " failed, you or your trade partner have an outstanding trade.");
                Chat.Send(to, "Trade from " + from.Name + " failed, you or your trade partner have an outstanding trade.");
                return;
            }
            string name;
            bool legalIds = ItemTypes.IndexLookup.TryGetName(give, out name );
            legalIds = legalIds && ItemTypes.IndexLookup.TryGetName(take, out name);

            if (!legalIds)
            {
                Chat.Send(from, "Invalid ID's");
                return;
            }

            Stockpile fromSP = Stockpile.GetStockPile(from);
            Stockpile toSP = Stockpile.GetStockPile(to);

            if (fromSP.AmountContained(take) <= takeamt)
            {
                Chat.Send(from, "You can't afford that trade.");
                return;
            }

            fromPd.tradeData = new TradeData(give, giveamt, take, takeamt, ref toPd, true);
            toPd.tradeData = new TradeData(take, takeamt, give, giveamt, ref fromPd, false);

            Chat.Send(from, "Trade sent to " + to.Name + ":");
            Chat.Send(from, fromPd.tradeData.ToString() + " from " + to.Name);
            Chat.Send(from, "Type '/trade reject' to cancel your trade.");
            Chat.Send(to, "Incoming trade request:");
            Chat.Send(to, toPd.tradeData.ToString() + " from " + from.Name);
            Chat.Send(to, "Type '/trade accept' to accept the trade.");
            Chat.Send(to, "Type '/trade reject' to reject the trade.");

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
                Chat.Send(Players.GetPlayer(player.ID), "You have no outstanding trade requests.");
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
                    Chat.Send(player, "Your partner can't afford this trade. It will need to be remade.");
                    Chat.Send(Players.GetPlayer(partnerData.PID), "You can't afford your trade with " + player.Name + ". Please get the required items and send another request.");
                    rejectTrade(player, true);
                    return;
                }

                if (playerStockpile.AmountContained(pd.tradeData.takeId) <= pd.tradeData.takeAmount)
                {
                    Chat.Send(player, "You can't afford this trade. Please get the required items or reject the trade.");
                    return;
                }

                playerStockpile.Remove(pd.tradeData.takeId, pd.tradeData.takeAmount);
                partnerStockpile.Remove(pd.tradeData.giveId, pd.tradeData.giveAmount);
                playerStockpile.Add(pd.tradeData.giveId, pd.tradeData.giveAmount);
                partnerStockpile.Add(pd.tradeData.takeId, pd.tradeData.takeAmount);
            } else
            {
                Chat.Send(player, "Your partner doesn't exist. Ignoring trade.");
                rejectTrade(player, true);
                return;
            }

            Chat.Send(player, "Trade Accepted.");
            Chat.Send(Players.GetPlayer(partnerData.PID), player.Name + " accepted your trade request.");

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

            PlayerData pd = getPlayerData(player);

            if (pd.tradeData == null)
            {
                Chat.Send(player, "You have no outstanding trade requests.");
                return;
            }

            PlayerData partnerData = playerDataDict[pd.tradeData.partner.PID];

            if (!isInternal)
            {
                Chat.Send(player, "Trade rejected.");
                Chat.Send(Players.GetPlayer(partnerData.PID), player.Name + " rejected your trade request.");
            }

            pd.tradeData = null;
            partnerData.tradeData = null;

            playerDataDict[pd.PID] = pd;
            playerDataDict[partnerData.PID] = partnerData;
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
            Stockpile playerStockpile = Stockpile.GetStockPile(from);
            Stockpile partnerStockpile = Stockpile.GetStockPile(to);

            string name;
            bool legalIds = ItemTypes.IndexLookup.TryGetName(give, out name);

            if (!legalIds)
            {
                Chat.Send(from, "Invalid ID's");
                return;
            }

            if (playerStockpile.AmountContained(give) <= giveamt)
            {
                Chat.Send(from, "You can't afford that.");
                return;
            }

            playerStockpile.Remove(give, giveamt);
            partnerStockpile.Add(give, giveamt);
            Chat.Send(from, "You sent " + giveamt + " " + name + " to " + to.Name + ".");
            Chat.Send(to, from.Name + " sent " + giveamt + " " + name + " to you.");
        }

        public static void notifyTeleport(Players.Player from, Players.Player to, bool here)
        {
            PlayerData fromPD = getPlayerData(from);
            PlayerData toPD = getPlayerData(to);

            if (fromPD.requestingTP || fromPD.tpRequester != NetworkID.Invalid)
            {
                Chat.Send(from, "You already have an outstanding tp request.");
                return;
            }

            if (toPD.tpRequester != NetworkID.Invalid || toPD.requestingTP)
            {
                Chat.Send(from, "That player already has a request.");
                Chat.Send(to, "Someone tried to send you a tp request, but you already have one.");
                return;
            }

            toPD.tpRequester = from.ID;
            fromPD.tpRequester = to.ID;
            fromPD.requestingTP = true;
            toPD.tpHere = here;

            Chat.Send(from, (here?"TPHere":"TP") + " request sent to " + to.Name + ".");
            Chat.Send(from, "Type '/tpreject' to cancel the request.");
            Chat.Send(to, (here ? "TPHere" : "TP") + " request from " + from.Name + ".");
            Chat.Send(to, "Type '/tpaccept' to allow " + from.Name + " to teleport " + (here?"here.":"to you, or type '/tpreject' to disallow."));

            playerDataDict[from.ID] = fromPD;
            playerDataDict[to.ID] = toPD;
        }

        public static void acceptTeleport(Players.Player ply)
        {
            PlayerData pd = getPlayerData(ply);
            bool sucessful = Players.TryGetPlayer(pd.tpRequester, out Players.Player partner);
            if (!sucessful)
            {
                Chat.Send(ply, "TP request invalid, deleting.");
            } else
            {
                PlayerData partnerPD = getPlayerData(partner);
                if (pd.tpHere)
                {
                    Chat.Send(ply, "Teleporting you to " + partner.Name + ".");
                    Chat.Send(partner, "Teleporting " + ply.Name + " to you.");
                    ChatCommands.Implementations.Teleport.TeleportTo(ply, partner.Position);
                } else
                {
                    Chat.Send(ply, "Teleporting " + partner.Name + " to you.");
                    Chat.Send(partner, "Teleporting you to " + ply.Name + ".");
                    ChatCommands.Implementations.Teleport.TeleportTo(partner, ply.Position);
                }
                partnerPD.tpRequester = NetworkID.Invalid;
                partnerPD.requestingTP = false;
                partnerPD.tpHere = false;
                playerDataDict[partner.ID] = partnerPD;
            }
            pd.tpRequester = NetworkID.Invalid;
            pd.requestingTP = false;
            pd.tpHere = false;
            playerDataDict[ply.ID] = pd;
        }

        public static void rejectTeleport(Players.Player ply)
        {
            PlayerData pd = getPlayerData(ply);
            bool sucessful = Players.TryGetPlayer(pd.tpRequester, out Players.Player partner);
            if (!sucessful )
            {
                Chat.Send(ply, "TP request invalid, deleting.");
            }
            else
            {
                PlayerData partnerPD = getPlayerData(partner);
                Chat.Send(ply, "You canceled your TP request to " + partner.Name + ".");
                Chat.Send(partner, ply.Name + " canceled their TP request.");
                partnerPD.tpRequester = NetworkID.Invalid;
                partnerPD.requestingTP = false;
                partnerPD.tpHere = false;
                playerDataDict[partner.ID] = partnerPD;
            }
            pd.tpRequester = NetworkID.Invalid;
            pd.requestingTP = false;
            pd.tpHere = false;
            playerDataDict[ply.ID] = pd;
        }
    }
}
