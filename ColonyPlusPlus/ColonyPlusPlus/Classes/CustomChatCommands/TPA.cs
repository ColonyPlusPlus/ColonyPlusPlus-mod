using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Permissions;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    class TPA : BaseChatCommand
    {
        public TPA() : base("/tpa", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "teleport.request"))
            {
                Managers.PlayerManager.notifyTeleport(ply, Players.GetPlayer(target), false);
            }
            return true;
        }
    }

    class TPAHere : BaseChatCommand
    {
        public TPAHere() : base("/tpahere", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "teleport.request"))
            {
                Managers.PlayerManager.notifyTeleport(ply, Players.GetPlayer(target), true);
            }
            return true;
        }
    }

    class TPAAccept : BaseChatCommand
    {
        public TPAAccept() : base("/tpaccept", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "teleport.request"))
            {
                Managers.PlayerManager.acceptTeleport(ply);
            }
            return true;
        }
    }

    class TPAReject : BaseChatCommand
    {
        public TPAReject() : base("/tpreject", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "teleport.request"))
            {
                Managers.PlayerManager.rejectTeleport(ply);
            }
            return true;
        }
    }
}
