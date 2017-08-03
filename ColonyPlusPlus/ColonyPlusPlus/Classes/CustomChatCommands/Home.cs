using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz.Chatting;
using Permissions;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    class Home : BaseChatCommand
    {
        public Home() : base("/home")
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "teleport.home"))
            {
                Chat.Send(ply, "Teleporting you to your banner...");
                Managers.PlayerManager.teleportPlayer(ply, Colony.Get(ply).Location);
            }
            return true;
        }
    }
}
