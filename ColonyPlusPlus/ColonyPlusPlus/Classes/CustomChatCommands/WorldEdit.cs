using ChatCommands;
using NPC;
using Permissions;
using ColonyPlusPlus.Classes.Helpers;
using System;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{

    public class WorldEdit : BaseChatCommand
    {
        public WorldEdit() : base("/worldedit")
        {

        }

        override protected bool RunCommand(Players.Player player, string[] args, NetworkID[] targets)
        {
            if(args.Length > 0)
            {
                string commandType = args[0];

                switch(commandType)
                {
                    case "fill":
                        Chat.send(player, "WorldEdit Command" + commandType, Chat.ChatColour.yellow);
                        return true;

                    case "clear":
                        Chat.send(player, "WorldEdit Command" + commandType, Chat.ChatColour.yellow);
                        return true;

                    case "circle":
                        Chat.send(player, "WorldEdit Command" + commandType, Chat.ChatColour.yellow);
                        return true;
                        
                    default:
                        Chat.send(player, "Invalid WorldEdit Command", Chat.ChatColour.yellow);
                        return false;

                }
                
            } else
            {
                Chat.send(player, "Invalid WorldEdit Command", Chat.ChatColour.yellow);
                Chat.send(player, "Usage: /worldedit {command} {arguments...}", Chat.ChatColour.yellow);
                return false;
            }
        }
    }
}

