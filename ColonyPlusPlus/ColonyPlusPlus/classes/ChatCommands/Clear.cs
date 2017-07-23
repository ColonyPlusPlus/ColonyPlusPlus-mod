using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.classes.ChatCommands
{

    public class Clear : IChatCommand
    {
        private static NetworkID GetSubject(NetworkID self, string[] splits)
        {
            Players.Player player;
            if (splits.Length < 3)
            {
                return self;
            }
            if (Players.TryMatchName(splits[2], out player))
            {
                return player.ID;
            }
            Chat.Send(self, $"Failed to find player named [{splits[2]}]", ChatSenderType.Server);
            return NetworkID.Invalid;
        }

        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/creative"));

        private bool ProcessCreative(NetworkID id, string chatItem)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "cheats.creative"))
            {
                // get their stockpile
                Stockpile s = Stockpile.GetStockPile(id);

                // CLEAR INVENTORY TODO

                Chat.Send(id, "Enabled Creative Mode", ChatSenderType.Server);
            }


            return true;
        }



        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            if (chatItem.StartsWith("/creative"))
            {
                return this.ProcessCreative(id, chatItem);
            }
            return false;
        }
    }
}

