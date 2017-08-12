using System;

namespace ColonyPlusPlusUtilities.CustomChatCommands
{
    public class Trade : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
    {
        public Trade() : base("/trade", false, true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (!Managers.ConfigManager.getConfigBoolean("trade.enable"))
            {
                Chat.Send(ply, "Trade has been disabled on this server.");
                return false;
            }
            else return true;
        }
    }

    public class TradeAccept : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
    {
        public TradeAccept() : base("/trade accept", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            Managers.PlayerManager.acceptTrade(ply);
            return true;
        }
    }

    public class TradeReject : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
    {
        public TradeReject() : base("/trade reject", false)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            Managers.PlayerManager.rejectTrade(ply);
            return true;
        }
    }

    public class TradeGive : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
    {

        public TradeGive() : base("/trade give", true)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (args.Length < 3)
            {
                ColonyAPI.Helpers.Chat.sendSilent(ply, "Not enough arguments. Usage:", ColonyAPI.Helpers.Chat.ChatColour.orange);
                ColonyAPI.Helpers.Chat.sendSilent(ply, "/trade give <playername> <myitemid> <myitemamount>", ColonyAPI.Helpers.Chat.ChatColour.orange);
                return true;
            }
            ushort giveid = 0;
            int giveamt = 0;
            bool sucessful = Utilities.TryParseItemFromArgument(args[1], out giveid);
            sucessful = sucessful && Int32.TryParse(args[2], out giveamt);
            if (!sucessful)
            {
                ColonyAPI.Helpers.Chat.sendSilent(ply, "Invalid argument. Usage:", ColonyAPI.Helpers.Chat.ChatColour.orange);
                ColonyAPI.Helpers.Chat.sendSilent(ply, "/trade give <playername> <myitemid> <myitemamount>", ColonyAPI.Helpers.Chat.ChatColour.orange);
                return true;
            }
            Managers.PlayerManager.tradeGive(ply, Players.GetPlayer(target), giveid, giveamt);
            return true;
        }
    }

    public class TradeSend : ColonyAPI.Classes.BaseChatCommand, ColonyAPI.Interfaces.IAutoChatCommand
    {
        public TradeSend() : base("/trade send", true)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (args.Length < 5)
            {
                ColonyAPI.Helpers.Chat.sendSilent(ply, "Not enough arguments. Usage:", ColonyAPI.Helpers.Chat.ChatColour.orange);
                ColonyAPI.Helpers.Chat.sendSilent(ply, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>", ColonyAPI.Helpers.Chat.ChatColour.orange);
                return true;
            }
            ushort takeid = 0;
            int takeamt = 0;
            ushort giveid = 0;
            int giveamt = 0;
            bool sucessful = Utilities.TryParseItemFromArgument(args[1], out giveid);
            sucessful = sucessful && Int32.TryParse(args[2], out takeamt);
            bool giveSucessful = Utilities.TryParseItemFromArgument(args[3], out giveid);
            sucessful = sucessful && giveSucessful;
            sucessful = sucessful && Int32.TryParse(args[4], out giveamt);
            if (!sucessful)
            {
                ColonyAPI.Helpers.Chat.sendSilent(ply, "Invalid argument. Usage:", ColonyAPI.Helpers.Chat.ChatColour.orange);
                ColonyAPI.Helpers.Chat.sendSilent(ply, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>", ColonyAPI.Helpers.Chat.ChatColour.orange);
                return true;
            }
            Managers.PlayerManager.notifyTrade(ply, Players.GetPlayer(target), giveid, giveamt, takeid, takeamt);
            return true;
        }
    }
}
