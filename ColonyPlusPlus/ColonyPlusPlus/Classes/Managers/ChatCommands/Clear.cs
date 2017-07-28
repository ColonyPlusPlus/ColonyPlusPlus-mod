using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
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
            (chatItem.StartsWith("/clear"));

        private bool ProcessCreative(NetworkID id, string chatItem)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "cheats.clear"))
            {
                // get their stockpile
                Stockpile s = Stockpile.GetStockPile(id);

                // Cycle through each item we manage, check how many we have, then remove that.
                foreach (string itemname in Classes.Managers.TypeManager.CreativeAddedTypes)
                {
                    ushort i = ItemTypes.IndexLookup.GetIndex(itemname);
                    s.Remove(i, s.AmountContained(i));
                }

                Chat.Send(id, "Cleared Inventory!", ChatSenderType.Server);
            }


            return true;
        }



        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            if (chatItem.StartsWith("/clear"))
            {
                return this.ProcessCreative(id, chatItem);
            }
            return false;
        }
    }
}

