using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class TradeReject : IChatCommand
    {
        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/trade reject"));

        public bool TryDoCommand(Players.Player id, string chatItem)
        {
            Managers.PlayerManager.rejectTrade(id);
            return true;
        }
    }
}

