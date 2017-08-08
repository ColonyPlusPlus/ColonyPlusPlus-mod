using Permissions;
using Chat = ColonyPlusPlus.Classes.Helpers.Chat;

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
                Chat.send(ply, $"Kicked {targetPlayer.Name}",Chat.ChatColour.magenta);
            }
            return true;
        }
    }
}
