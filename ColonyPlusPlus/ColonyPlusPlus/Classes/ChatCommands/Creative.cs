using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class Creative : IChatCommand
    {
        

        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/creative"));

        private bool ProcessCreative(Players.Player id, string chatItem)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "cheats.creative"))
            {
                // get their stockpile
                Stockpile s =  Stockpile.GetStockPile(id);

                foreach(string itemname in Classes.Managers.TypeManager.CreativeAddedTypes)
                {
                    ushort i = ItemTypes.IndexLookup.GetIndex(itemname);
                    s.Add(i, 10000);
                }

                Chat.Send(id, "Enabled Creative Mode", ChatSenderType.Server);
            }

            
            return true;
        }

        

        public bool TryDoCommand(Players.Player id, string chatItem)
        {
            if (chatItem.StartsWith("/creative"))
            {
                return this.ProcessCreative(id, chatItem);
            }
            return false;
        }
    }
}

