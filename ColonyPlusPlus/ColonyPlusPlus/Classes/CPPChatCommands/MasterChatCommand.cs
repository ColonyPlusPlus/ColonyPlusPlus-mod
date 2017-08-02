using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatCommands;

namespace ColonyPlusPlus.Classes.CPPChatCommands
{
    public class MasterChatCommand : IChatCommand
    {
        public bool IsCommand(string chatItem) =>
            (Managers.ChatCommandManager.ChatCommandsList.ContainsKey(chatItem.Split(' ')[0]));

        public bool TryDoCommand(Players.Player ply, string chatItem)
        {
            BaseChatCommand command;
            Managers.ChatCommandManager.ChatCommandsList.TryGetValue(chatItem.Split(' ')[0], out command);
            if (command != null)
            {
                return command.TryDoCommand(ply, chatItem);
            }
            return false;
        }
    }
}
