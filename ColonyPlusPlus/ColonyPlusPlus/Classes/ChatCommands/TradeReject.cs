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
            (chatItem.StartsWith("/tradereject"));

        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            if (chatItem.StartsWith("/tradereject"))
            {
                Managers.PlayerManager.rejectTrade(Players.GetPlayer(id));
                return true;
            }
            return false;
        }
    }
}

