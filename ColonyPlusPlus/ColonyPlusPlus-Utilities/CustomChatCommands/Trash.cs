using System;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{

    public class Trash : BaseChatCommand
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
                    Helpers.Chat.send(ply, "Invalid arguments. Usage:", Helpers.Chat.ChatColour.orange);
                    Helpers.Chat.send(ply, "/trash <itemid> <itemamount> - trash an amount of an item", Helpers.Chat.ChatColour.orange);
                    Helpers.Chat.send(ply, "/trash <itemid> - trash all of an item", Helpers.Chat.ChatColour.orange);
                    return true;
                }
                
            } else
            {
                Utilities.WriteLog(args[1]);
                successful2 = Int32.TryParse(args[1], out giveamt);
            }

            sucessful = UInt16.TryParse(args[0], out itemid);
            if (!sucessful)
            {
                sucessful = sucessful || ItemTypes.IndexLookup.TryGetIndex(args[0], out itemid);
            }


            if ((!sucessful) || (!successful2))
            {
                Helpers.Chat.send(ply, "Invalid arguments. Usage:", Helpers.Chat.ChatColour.orange);
                Helpers.Chat.send(ply, "/trash <itemid> <itemamount> - trash an amount of an item", Helpers.Chat.ChatColour.orange);
                Helpers.Chat.send(ply, "/trash <itemid> - trash all of an item", Helpers.Chat.ChatColour.orange);
                return true;
            }

            Managers.PlayerManager.trashItems(ply, itemid, giveamt);
            return true;
        }
    }
}

