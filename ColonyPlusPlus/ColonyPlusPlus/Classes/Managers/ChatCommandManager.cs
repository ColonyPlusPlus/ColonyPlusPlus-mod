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
            ChatCommandsList = new Dictionary<string, CPPChatCommands.BaseChatCommand>();
            var typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => (t.Namespace.StartsWith("ColonyPlusPlus.Classes.CPPChatCommands") || t.Name.StartsWith("IChatCommand")));
            foreach (var t in typelist)
            {
                try
                {
                    CPPChatCommands.BaseChatCommand command = ((CPPChatCommands.BaseChatCommand)Activator.CreateInstance(t));
                    ChatCommandsList.Add(command.ChatCommandPrefix, command);
                    Utilities.WriteLog("Registered chat command: " + command.ChatCommandPrefix);
                }
                catch (MissingMethodException mme)
                {
                    Utilities.WriteLog(t.Name + " cannot be instantiated. This probably isn't an error.");
                    Pipliz.Log.WriteWarning(mme.Message);
                }
                catch (InvalidCastException ice)
                {
                    Utilities.WriteLog(t.Name + " doesn't use our command system. This probably isn't an error.");
                    Pipliz.Log.WriteWarning(ice.Message);
                }
            }
            Utilities.WriteLog("Chat Commands Loaded.");
        }
    }
}
