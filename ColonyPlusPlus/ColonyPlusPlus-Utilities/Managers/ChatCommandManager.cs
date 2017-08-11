using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ColonyPlusPlusUtilities.Managers
{
    public static class ChatCommandManager
    {
        public static Dictionary<String, BaseChatCommand> ChatCommandsList;

        public static void Initialize()
        {
            ChatCommandsList = new Dictionary<string, BaseChatCommand>();
            var typelist = Assembly.GetExecutingAssembly().GetTypes().Where(t => (t != null && t.Namespace != null && t.Namespace.StartsWith("ColonyPlusPlus.Classes.CustomChatCommands")));
            foreach (var t in typelist)
            {
                try
                {
                    BaseChatCommand command = ((BaseChatCommand)Activator.CreateInstance(t));
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
                catch (Exception e)
                {
                    Utilities.WriteLog(t.Name + " Command Error.");
                    Pipliz.Log.WriteWarning(e.Message + e.StackTrace);
                }
            }
            Utilities.WriteLog("Chat Commands Loaded.");
        }
    }
}
