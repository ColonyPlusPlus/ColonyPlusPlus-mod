using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ChatCommands;

namespace ColonyPlusPlus.Classes
{
    public class MasterChatCommand : IChatCommand
    {
        public bool IsCommand(string chatItem) =>
            (Managers.ChatCommandManager.ChatCommandsList.ContainsKey(chatItem.Split(' ')[0]));

        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            CPPChatCommands.BaseChatCommand command;
            Managers.ChatCommandManager.ChatCommandsList.TryGetValue(chatItem.Split(' ')[0], out command);
            if (command != null)
            {
                return command.TryDoCommand(id, chatItem);
            }
            return false;
        }
    }
}
