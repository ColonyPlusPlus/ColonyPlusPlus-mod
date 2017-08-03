using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{

    public class Creative : BaseChatCommand
    {
        public Creative() : base("/creative", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "cheats.creative"))
            {
                // get their stockpile
                Stockpile s =  Stockpile.GetStockPile(ply);

                foreach(string itemname in Managers.TypeManager.CreativeAddedTypes)
                {
                    ushort i = ItemTypes.IndexLookup.GetIndex(itemname);
                    s.Add(i, 10000);
                }

                Chat.Send(ply, "Enabled Creative Mode", ChatSenderType.Server);
            }
            
            return true;
        }
    }
}

