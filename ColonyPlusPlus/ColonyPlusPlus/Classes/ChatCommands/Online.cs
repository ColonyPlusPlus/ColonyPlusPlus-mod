using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;
using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class Online : IChatCommand
    {
        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/online"));

        private bool Process(NetworkID id, string chatItem)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "online"))
            {

                List<string> online = new List<string>() ;

                for(int i = 0; i < Players.CountConnected; i++)
                {
                    Players.Player p = Players.GetConnectedByIndex(i);
                    online.Add(p.Name);
                }

                online.Sort();
                
                Chat.Send(id, String.Format("Players Online ({0}): {1}",Players.CountConnected, String.Join(", ",online.ToArray())), ChatSenderType.Server);
            }


            return true;
        }



        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            if (chatItem.StartsWith("/online"))
            {
                return this.Process(id, chatItem);
            }
            return false;
        }
    }
}

