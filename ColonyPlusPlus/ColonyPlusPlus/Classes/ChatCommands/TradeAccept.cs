using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class TradeAccept : IChatCommand
    {
        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/tradeaccept"));

        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            Managers.PlayerManager.acceptTrade(Players.GetPlayer(id));
            return true;
        }
    }
}

