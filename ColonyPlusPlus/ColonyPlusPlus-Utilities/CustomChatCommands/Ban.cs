using System;
using Permissions;
using Chat = ColonyPlusPlus.Classes.Helpers.Chat;

namespace ColonyPlusPlusUtilities.CustomChatCommands
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
                var targetPlayer = Players.GetPlayer(target);
                BlackAndWhitelisting.AddBlackList(targetPlayer.ID.steamID.m_SteamID);

                var reason = "";
                if (args.Length > 1)
                {
                    reason = String.Join(" ", args, 1, args.Length - 1);
                }

                Classes.Managers.BanManager.addBan(targetPlayer.ID, reason);
                ServerManager.Disconnect(targetPlayer);
                Chat.send(ply, $"Banned {targetPlayer.Name}", Chat.ChatColour.cyan);
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
                Classes.Managers.BanManager.removeBan(targetPlayer.ID);
                BlackAndWhitelisting.RemoveBlackList(targetPlayer.ID.steamID.m_SteamID);
                Chat.send(ply, $"Unbanned {targetPlayer.Name}", Chat.ChatColour.cyan);
            }
            return true;
        }
    }
}
