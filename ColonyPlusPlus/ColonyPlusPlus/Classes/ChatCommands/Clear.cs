using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class Clear : IChatCommand
    {
       

        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/clear"));

        private bool ProcessCreative(Players.Player id, string chatItem)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "cheats.clear"))
            {
                // get their stockpile
                Stockpile s = Stockpile.GetStockPile(id);

                // Cycle through each item we manage, check how many we have, then remove that.
                foreach (string itemname in Classes.Managers.TypeManager.AddedTypes)
                {
                    ushort i = ItemTypes.IndexLookup.GetIndex(itemname);
                    s.Remove(i, s.AmountContained(i));
                }

                Chat.Send(id, "Cleared Inventory!", ChatSenderType.Server);
            }


            return true;
        }



        public bool TryDoCommand(Players.Player id, string chatItem)
        {
            if (chatItem.StartsWith("/clear"))
            {
                return this.ProcessCreative(id, chatItem);
            }
            return false;
        }
    }
}

