using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Permissions;
using Pipliz.Chatting;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    class TP : ColonyAPI.Classes.BaseChatCommand
    {
        public TP() : base("/tp", false, true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (!ColonyAPI.Managers.ConfigManager.getConfigBoolean("tp", "enable"))
            {
                Chat.Send(ply, "TP is disabled on this server.");
                return false;
            }
            else if (!(PermissionsManager.CheckAndWarnPermission(ply, "tp.request") || PermissionsManager.CheckAndWarnPermission(ply, "tp.admin")))
            {
                Chat.Send(ply, "You don't have permission to use tp.");
                return false;
            }
            else return true;
        }
    }

    class TPR : ColonyAPI.Classes.BaseChatCommand
    {
        public TPR() : base("/tp request", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            ColonyPlusPlusUtilities.Managers.PlayerManager.notifyTeleport(ply, Players.GetPlayer(target), false);
            return true;
        }
    }

    class TPAHere : ColonyAPI.Classes.BaseChatCommand
    {
        public TPAHere() : base("/tp here", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            ColonyPlusPlusUtilities.Managers.PlayerManager.notifyTeleport(ply, Players.GetPlayer(target), true);
            return true;
        }
    }

    class TPAAccept : ColonyAPI.Classes.BaseChatCommand
    {
        public TPAAccept() : base("/tp accept", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            ColonyPlusPlusUtilities.Managers.PlayerManager.acceptTeleport(ply);
            return true;
        }
    }

    class TPAReject : ColonyAPI.Classes.BaseChatCommand
    {
        public TPAReject() : base("/tp reject", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            ColonyPlusPlusUtilities.Managers.PlayerManager.rejectTeleport(ply);
            return true;
        }
    }

    class TPAdmin : ColonyAPI.Classes.BaseChatCommand
    {
        public TPAdmin() : base("/tp admin", true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "tp.admin"))
            {
                Players.Player targetPly = Players.GetPlayer(target);
                ChatCommands.Implementations.Teleport.TeleportTo(ply, targetPly.Position);
                Chat.Send(ply, "Teleported you to " + targetPly.Name);
            }
            else
            {
                Chat.Send(ply, "You don't have permission to admin teleport.");
            }
            return true;
        }
    }
}
