using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;
using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{

    public class Online : BaseChatCommand
    {
        public Online() : base("/online", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
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
                
                Chat.Send(ply, String.Format("Players Online ({0}): {1}",Players.CountConnected, String.Join(", ",online.ToArray())), ChatSenderType.Server);
            }
            
            return true;
        }
    }
}

