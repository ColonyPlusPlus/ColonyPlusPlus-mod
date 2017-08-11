using Permissions;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{

    public class Clear : BaseChatCommand
    {
        public Clear() : base("/clear", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "cheats.clear"))
            {
                // get their stockpile
                Stockpile s = Stockpile.GetStockPile(ply);

                // Cycle through each item we manage, check how many we have, then remove that.
                foreach (string itemname in Managers.TypeManager.AddedTypes)
                {
                    ushort i = ItemTypes.IndexLookup.GetIndex(itemname);
                    s.Remove(i, s.AmountContained(i));
                }

                Helpers.Chat.sendSilent(ply, "Cleared Inventory!", Helpers.Chat.ChatColour.lime);
            }
            
            return true;
        }
    }
}

