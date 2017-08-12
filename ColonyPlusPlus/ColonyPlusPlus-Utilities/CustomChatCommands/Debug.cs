using Permissions;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{

    public class Debug : BaseChatCommand
    {
        public Debug() : base("/cppdebug", false, true)
        {

        }

		protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
		{
			return false;
		}




    }

    public class DebugTypes: BaseChatCommand
    {
        public DebugTypes() : base("/cppdebug json") {
            
        }

		override protected bool RunCommand(Players.Player player, string[] args, NetworkID target)
		{
			if (PermissionsManager.CheckAndWarnPermission(player, "debug") && ColonyAPI.Managers.ConfigManager.getConfigBoolean("ColonyPlusPlusUtilities", "debug.enabled"))
			{
				Helpers.Debug.outputTypes();
                Helpers.Debug.outputRecipes();

				ColonyAPI.Helpers.Chat.send(player, "Outputted JSON to Debug Directory", ColonyAPI.Helpers.Chat.ChatColour.yellow);
				return true;


			}
			else
			{
				ColonyAPI.Helpers.Chat.send(player, "You are unable to use debug commands", ColonyAPI.Helpers.Chat.ChatColour.yellow);
				return false;
			}

		}
    }
}

