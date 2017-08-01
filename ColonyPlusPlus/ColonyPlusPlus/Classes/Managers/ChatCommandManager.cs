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
            try
            {
                var typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => (t.Namespace.StartsWith("ColonyPlusPlus.Classes.CPPChatCommands") || t.Name.StartsWith("IChatCommand")));
                foreach (var t in typelist)
                {
                    try
                    {
                        if (t.Equals(typeof(CPPChatCommands.BaseChatCommand)))
                        {
                            CPPChatCommands.BaseChatCommand command = ((CPPChatCommands.BaseChatCommand)Activator.CreateInstance(t));
                            ChatCommandsList.Add(command.ChatCommandPrefix, command);
                        }
                    }
                    catch (MethodAccessException mae)
                    {
                        // No worries here, we encountered an abstract class.
                        Utilities.WriteLog(mae.Message);
                    }
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                // No worries here, we encountered a reflection error.
                Utilities.WriteLog(ex.Message);
                var typelist = ex.Types;
                foreach (var t in typelist)
                {
                    try
                    {
                        if (t.Equals(typeof(CPPChatCommands.BaseChatCommand)))
                        {
                            CPPChatCommands.BaseChatCommand command = ((CPPChatCommands.BaseChatCommand)Activator.CreateInstance(t));
                            ChatCommandsList.Add(command.ChatCommandPrefix, command);
                        }
                    }
                    catch (MethodAccessException mae)
                    {
                        // No worries here, we encountered an abstract class.
                        Utilities.WriteLog(mae.Message);
                    }
                }
            }
            Utilities.WriteLog("Chat Commands Loaded.");
        }

        public static void RegisterCommands()
        {
            foreach (CPPChatCommands.BaseChatCommand command in ChatCommandsList.Values)
            {
                ChatCommands.CommandManager.RegisterCommand((ChatCommands.IChatCommand) command);
            }
        }
    }
}
