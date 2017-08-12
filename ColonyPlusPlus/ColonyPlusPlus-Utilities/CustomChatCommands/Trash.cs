using System;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{

    public class Trash : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
    {
        public Trash() : base("/trash")
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            ushort itemid = 0;
            int giveamt = 0;
            bool sucessful = false;
            bool successful2 = false;

            if (args.Length < 2)
            {
                if(args.Length == 1)
                {
                    giveamt = 1000000000;
                    successful2 = true;
                } else
                {
                    ColonyAPI.Helpers.Chat.send(ply, "Invalid arguments. Usage:", ColonyAPI.Helpers.Chat.ChatColour.orange);
                    ColonyAPI.Helpers.Chat.send(ply, "/trash <itemid> <itemamount> - trash an amount of an item", ColonyAPI.Helpers.Chat.ChatColour.orange);
                    ColonyAPI.Helpers.Chat.send(ply, "/trash <itemid> - trash all of an item", ColonyAPI.Helpers.Chat.ChatColour.orange);
                    return true;
                }
                
            } else
            {
                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Utilities", args[1]);
                successful2 = Int32.TryParse(args[1], out giveamt);
            }

            sucessful = UInt16.TryParse(args[0], out itemid);
            if (!sucessful)
            {
                sucessful = sucessful || ItemTypes.IndexLookup.TryGetIndex(args[0], out itemid);
            }


            if ((!sucessful) || (!successful2))
            {
                ColonyAPI.Helpers.Chat.send(ply, "Invalid arguments. Usage:", ColonyAPI.Helpers.Chat.ChatColour.orange);
                ColonyAPI.Helpers.Chat.send(ply, "/trash <itemid> <itemamount> - trash an amount of an item", ColonyAPI.Helpers.Chat.ChatColour.orange);
                ColonyAPI.Helpers.Chat.send(ply, "/trash <itemid> - trash all of an item", ColonyAPI.Helpers.Chat.ChatColour.orange);
                return true;
            }

            Managers.PlayerManager.trashItems(ply, itemid, giveamt);
            return true;
        }
    }
}

