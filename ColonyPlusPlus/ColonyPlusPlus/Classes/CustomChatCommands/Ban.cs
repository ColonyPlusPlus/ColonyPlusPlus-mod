using Permissions;
using Pipliz.Chatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    public class Ban : BaseChatCommand
    {
        public Ban() : base("/ban", true)
        {
        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "ban"))
            {
                //TODO: Log bans
                var targetPlayer = Players.GetPlayer(target);
                BlackAndWhitelisting.AddBlackList(targetPlayer.ID.steamID.m_SteamID);
                ServerManager.Disconnect(targetPlayer);
                Chat.Send(ply, $"Banned {targetPlayer.Name}");
            }
            return true;
        }
    }

    public class Unban : BaseChatCommand
    {
        public Unban() : base("/unban", true)
        {
        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "unban"))
            {
                //TODO: Log unbans
                var targetPlayer = Players.GetPlayer(target);
                BlackAndWhitelisting.RemoveBlackList(targetPlayer.ID.steamID.m_SteamID);
                Chat.Send(ply, $"Unbanned {targetPlayer.Name}");
            }
            return true;
        }
    }
}
