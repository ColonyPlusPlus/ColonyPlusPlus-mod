using Permissions;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{
    public class Kick : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
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
                ColonyAPI.Helpers.Chat.send(ply, $"Kicked {targetPlayer.Name}", ColonyAPI.Helpers.Chat.ChatColour.magenta);
            }
            return true;
        }
    }
}
