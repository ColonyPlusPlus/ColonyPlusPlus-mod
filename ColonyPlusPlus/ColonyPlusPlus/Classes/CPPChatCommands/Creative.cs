using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.CPPChatCommands
{

    public class Creative : BaseChatCommand
    {
        public Creative() : base("/creative", false)
        {

        }

        override protected bool RunCommand(NetworkID id, string[] args, NetworkID target)
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
    }
}

