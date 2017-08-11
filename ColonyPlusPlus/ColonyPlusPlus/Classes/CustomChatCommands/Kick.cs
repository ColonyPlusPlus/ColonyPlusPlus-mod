using Permissions;
using Chat = ColonyPlusPlus.Classes.Helpers.Chat;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    public class Kick : BaseChatCommand
    {
        public Kick() : base("/kick", true)
        {
        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "kick"))
            {
                var targetPlayer = Players.GetPlayer(targets[0]);
                ServerManager.Disconnect(targetPlayer);
                Chat.send(ply, $"Kicked {targetPlayer.Name}",Chat.ChatColour.magenta);
            }
            return true;
        }
    }
}
