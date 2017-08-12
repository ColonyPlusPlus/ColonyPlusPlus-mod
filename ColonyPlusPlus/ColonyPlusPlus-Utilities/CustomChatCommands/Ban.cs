using System;
using Permissions;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{
    public class Ban : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
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

                Managers.BanManager.addBan(targetPlayer.ID, reason);
                ServerManager.Disconnect(targetPlayer);
                ColonyAPI.Helpers.Chat.send(ply, $"Banned {targetPlayer.Name}", ColonyAPI.Helpers.Chat.ChatColour.cyan);
            }
            return true;
        }
    }

    public class Unban : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
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
                Managers.BanManager.removeBan(targetPlayer.ID);
                BlackAndWhitelisting.RemoveBlackList(targetPlayer.ID.steamID.m_SteamID);
                ColonyAPI.Helpers.Chat.send(ply, $"Unbanned {targetPlayer.Name}", ColonyAPI.Helpers.Chat.ChatColour.cyan);
            }
            return true;
        }
    }
}
