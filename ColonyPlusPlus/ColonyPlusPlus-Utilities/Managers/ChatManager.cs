using ChatCommands;
using Permissions;
using Pipliz.JSON;
using System;
using ColonyAPI.Helpers;
using ColonyAPI.Managers;

namespace ColonyPlusPlusUtilities.Managers
{
    class ChatManager : IChatCommand
    {
        public bool IsCommand(string chat)
        {
            return !chat.StartsWith("/");
        }

        public bool TryDoCommand(Players.Player player, string chat)
        {
            if(ConfigManager.getConfigBoolean("ColonyPlusPlus-Utilities", "chat.enabled"))
            {
                JSONNode chatColors = ConfigManager.getConfigNode("ColonyPlusPlus-Utilities", "chat.colors");
                string chatColor = "white";
                string chatStyle = "normal";
                string playerPerm = "";
                string chatPrefix = ""; 

                foreach (JSONNode perm in chatColors.LoopArray())
                {
                    string permName = "somesuperspecificplaceholderstringthatwillneverexist";
                    perm.TryGetAs<string>("permissionstring", out permName);

                    if (PermissionsManager.HasPermission(player, permName))
                    {
                        // this player is in this group
                        playerPerm = permName;
                        perm.TryGetAs<string>("color", out chatColor);
                        perm.TryGetAs<string>("style", out chatStyle);
                        perm.TryGetAs<string>("prefix", out chatPrefix);
                    }

                }

                
                Chat.ChatColour chatColorEnum = (Chat.ChatColour)Enum.Parse(typeof(Chat.ChatColour), chatColor);
                Chat.ChatStyle chatStyleEnum = (Chat.ChatStyle)Enum.Parse(typeof(Chat.ChatStyle), chatStyle);

                string message = "";
                if (chatPrefix != "")
                {
                    message = String.Format("[{0}] {1}: {2}", chatPrefix, player.Name, chat);
                } else
                {
                    message = String.Format("{0}: {1}", player.Name, chat);
                }

                Chat.sendToAll(message , chatColorEnum, chatStyleEnum);
            } else
            {
                Chat.sendToAll(String.Format("{0}: {1}", player.Name, chat), Chat.ChatColour.white);
            }

                

            
            return true;
        }
    }
}
