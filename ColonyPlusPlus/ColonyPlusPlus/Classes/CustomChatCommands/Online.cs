using ChatCommands;
using NPC;
using Permissions;
using ColonyPlusPlus.Classes.Helpers;
using System;
using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{

    public class Online : BaseChatCommand
    {
        public Online() : base("/online", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "online"))
            {

                List<string> online = new List<string>() ;

                for(int i = 0; i < Players.CountConnected; i++)
                {
                    Players.Player p = Players.GetConnectedByIndex(i);
                    online.Add(p.Name);
                }

                online.Sort();
                
                Chat.send(ply, String.Format("Players Online ({0}): {1}",Players.CountConnected, String.Join(", ",online.ToArray())), Chat.ChatColour.white, Chat.ChatStyle.normal ,Pipliz.Chatting.ChatSenderType.Server);
            }
            
            return true;
        }
    }
}

