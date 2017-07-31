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
            (chatItem.StartsWith("/trade accept"));

        public bool TryDoCommand(Players.Player id, string chatItem)
        {
            Managers.PlayerManager.acceptTrade(id);
            return true;
        }
    }
}

