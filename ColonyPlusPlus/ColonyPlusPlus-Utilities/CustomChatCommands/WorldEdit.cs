namespace ColonyPlusPlusUtilities.CustomChatCommands
{

    public class WorldEdit : BaseChatCommand
    {
        public WorldEdit() : base("/worldedit")
        {

        }

        override protected bool RunCommand(Players.Player player, string[] args, NetworkID target)
        {
            if(args.Length > 0)
            {
                string commandType = args[0];

                switch(commandType)
                {
                    case "fill":
                        ColonyAPI.Helpers.Chat.send(player, "WorldEdit Command" + commandType, ColonyAPI.Helpers.Chat.ChatColour.yellow);
                        return true;

                    case "clear":
                        ColonyAPI.Helpers.Chat.send(player, "WorldEdit Command" + commandType, ColonyAPI.Helpers.Chat.ChatColour.yellow);
                        return true;

                    case "circle":
                        ColonyAPI.Helpers.Chat.send(player, "WorldEdit Command" + commandType, ColonyAPI.Helpers.Chat.ChatColour.yellow);
                        return true;
                        
                    default:
                        ColonyAPI.Helpers.Chat.send(player, "Invalid WorldEdit Command", ColonyAPI.Helpers.Chat.ChatColour.yellow);
                        return false;

                }
                
            } else
            {
                ColonyAPI.Helpers.Chat.send(player, "Invalid WorldEdit Command", ColonyAPI.Helpers.Chat.ChatColour.yellow);
                ColonyAPI.Helpers.Chat.send(player, "Usage: /worldedit {command} {arguments...}", ColonyAPI.Helpers.Chat.ChatColour.yellow);
                return false;
            }
        }
    }
}

