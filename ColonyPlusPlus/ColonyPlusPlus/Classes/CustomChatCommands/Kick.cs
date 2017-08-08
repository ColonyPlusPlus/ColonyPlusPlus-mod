using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Permissions;
using Pipliz.Chatting;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    public class Kick : BaseChatCommand
    {
        public Kick() : base("/kick", true)
        {
        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "kick"))
            {
                var targetPlayer = Players.GetPlayer(target);
                ServerManager.Disconnect(targetPlayer);
               Helpers.Chat.send(ply, $"Kicked {targetPlayer.Name}", Helpers.Chat.ChatColour.magenta);
            }
            return true;
        }
    }
}
