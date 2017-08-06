using ChatCommands;
using Permissions;
using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    class ChatManager : IChatCommand
    {
        public bool IsCommand(string chat)
        {
            return !chat.StartsWith("/");
        }

        public bool TryDoCommand(Players.Player player, string chat)
        {
            if(ConfigManager.getConfigBoolean("chat.enabled"))
            {
                JSONNode chatColors = ConfigManager.getConfigNode("chat.colors");
                string chatColor = "white";
                string chatStyle = "normal";
                string playerPerm = "";

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
                    }

                }

                
                Helpers.Chat.ChatColour chatColorEnum = (Helpers.Chat.ChatColour)Enum.Parse(typeof(Helpers.Chat.ChatColour), chatColor);
                Helpers.Chat.ChatStyle chatStyleEnum = (Helpers.Chat.ChatStyle)Enum.Parse(typeof(Helpers.Chat.ChatStyle), chatStyle);

                Helpers.Chat.sendToAll(chat, chatColorEnum, chatStyleEnum);
            } else
            {
                Helpers.Chat.sendToAll(chat, Helpers.Chat.ChatColour.white);
            }

                

            
            return true;
        }
    }
}
