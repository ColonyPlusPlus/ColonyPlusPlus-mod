using ChatCommands;
using NPC;
using Permissions;
using ColonyPlusPlus.Classes.Helpers;
using System;

namespace ColonyPlusPlus.Classes.CPPChatCommands
{

    public class WorldEdit : BaseChatCommand
    {
        public WorldEdit() : base("/worldedit")
        {

        }

        override protected bool RunCommand(Players.Player id, string[] args, NetworkID target)
        {
            if(args.Length > 1)
            {
                Chat.send(id, args[1],Chat.ChatColour.magenta);

                return true;
            } else
            {
                return false;
            }
        }
    }
}

