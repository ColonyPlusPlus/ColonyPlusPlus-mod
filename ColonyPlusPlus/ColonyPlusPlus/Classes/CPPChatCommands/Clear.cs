using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.CPPChatCommands
{

    public class Clear : BaseChatCommand
    {
        public Clear() : base("/clear", false)
        {

        }

        override protected bool RunCommand(NetworkID id, string[] args, NetworkID target)
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
    }
}

