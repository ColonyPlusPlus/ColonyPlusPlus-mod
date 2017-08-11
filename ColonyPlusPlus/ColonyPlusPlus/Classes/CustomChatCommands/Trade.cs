using ColonyPlusPlus.Classes.Helpers;
using System;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    public class Trade : BaseChatCommand
    {
        public Trade() : base("/trade", false, true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            return false;
        }
    }

    public class TradeAccept : BaseChatCommand
    {
        public TradeAccept() : base("/trade accept", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            Managers.PlayerManager.acceptTrade(ply);
            return true;
        }
    }

    public class TradeReject : BaseChatCommand
    {
        public TradeReject() : base("/trade reject", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            Managers.PlayerManager.rejectTrade(ply);
            return true;
        }
    }

    public class TradeGive : BaseChatCommand
    {

        public TradeGive() : base("/trade give", true)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            if (args.Length < 3)
            {
                Helpers.Chat.sendSilent(ply, "Not enough arguments. Usage:", Helpers.Chat.ChatColour.orange);
                Helpers.Chat.sendSilent(ply, "/trade give <playername> <myitemid> <myitemamount>", Helpers.Chat.ChatColour.orange);
                return true;
            }
            ushort giveid = 0;
            int giveamt = 0;
            bool sucessful = UInt16.TryParse(args[1], out giveid);
            if (!sucessful)
            {
                sucessful = sucessful || ItemTypes.IndexLookup.TryGetIndex(args[1], out giveid);
            }
            sucessful = sucessful && Int32.TryParse(args[2], out giveamt);
            if (!sucessful)
            {
                Helpers.Chat.sendSilent(ply, "Invalid argument. Usage:", Helpers.Chat.ChatColour.orange);
                Helpers.Chat.sendSilent(ply, "/trade give <playername> <myitemid> <myitemamount>", Helpers.Chat.ChatColour.orange);
                return true;
            }
            Managers.PlayerManager.tradeGive(ply, Players.GetPlayer(targets[0]), giveid, giveamt);
            return true;
        }
    }

    public class TradeSend : BaseChatCommand
    {
        public TradeSend() : base("/trade send", true)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            if (args.Length < 5)
            {
                Helpers.Chat.sendSilent(ply, "Not enough arguments. Usage:", Helpers.Chat.ChatColour.orange);
                Helpers.Chat.sendSilent(ply, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>", Helpers.Chat.ChatColour.orange);
                return true;
            }
            ushort takeid = 0;
            int takeamt = 0;
            ushort giveid = 0;
            int giveamt = 0;
            bool sucessful = UInt16.TryParse(args[1], out takeid);
            if (!sucessful)
            {
                sucessful = sucessful || ItemTypes.IndexLookup.TryGetIndex(args[1], out takeid);
            }
            sucessful = sucessful && Int32.TryParse(args[2], out takeamt);
            bool giveSucessful = UInt16.TryParse(args[3], out giveid);
            if (!giveSucessful)
            {
                giveSucessful = giveSucessful || ItemTypes.IndexLookup.TryGetIndex(args[3], out giveid);
            }
            sucessful = sucessful && giveSucessful;
            sucessful = sucessful && Int32.TryParse(args[4], out giveamt);
            if (!sucessful)
            {
                Helpers.Chat.sendSilent(ply, "Invalid argument. Usage:", Helpers.Chat.ChatColour.orange);
                Helpers.Chat.sendSilent(ply, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>", Helpers.Chat.ChatColour.orange);
                return true;
            }
            Managers.PlayerManager.notifyTrade(ply, Players.GetPlayer(targets[0]), giveid, giveamt, takeid, takeamt);
            return true;
        }
    }
}
