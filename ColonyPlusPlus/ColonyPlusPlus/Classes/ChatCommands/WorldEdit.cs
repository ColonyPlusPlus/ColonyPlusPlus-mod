using ChatCommands;
using NPC;
using Permissions;
using ColonyPlusPlus.Classes.Helpers;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class WorldEdit : IChatCommand
    {
        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/wordledit"));

        private bool ProcessCommand(Players.Player id, string chatItem)
        {
            string[] commandArr = chatItem.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if(commandArr.Length > 1)
            {
                Chat.send(id, commandArr[1],Chat.ChatColour.magenta);

                return true;
            } else
            {
                return false;
            }

            
            
        }



        public bool TryDoCommand(Players.Player id, string chatItem)
        {
            if (IsCommand(chatItem))
            {
                return this.ProcessCommand(id, chatItem);
            }
            return false;
        }
    }
}

