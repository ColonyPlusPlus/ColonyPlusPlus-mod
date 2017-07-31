using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class ChatCommandManager
    {
        public static Dictionary<String, CPPChatCommands.BaseChatCommand> ChatCommandsList;

        public static void Initialize()
        {
            var typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Namespace.StartsWith("ColonyPlusPlus.Classes.CPPChatCommands"));
            foreach (var t in typelist)
            {
                try
                {
                    CPPChatCommands.BaseChatCommand command = ((CPPChatCommands.BaseChatCommand)Activator.CreateInstance(t));
                    ChatCommandsList.Add(command.ChatCommandPrefix, command);
                } catch (MethodAccessException mae)
                {
                    // No worries here, we encountered an abstract class.
                    Utilities.WriteLog(t.Name + " is an abstract or private class, skipping.");
                    Utilities.WriteLog(mae.Message);
                }
            }
        }

        public static void RegisterCommands()
        {
            foreach (CPPChatCommands.BaseChatCommand command in ChatCommandsList.Values)
            {
                ChatCommands.CommandManager.RegisterCommand(command);
            }
        }
    }
}
