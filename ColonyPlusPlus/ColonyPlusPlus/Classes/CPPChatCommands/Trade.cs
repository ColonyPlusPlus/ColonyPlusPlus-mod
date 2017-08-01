using Pipliz.Chatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.CPPChatCommands
{
    public class Trade : BaseChatCommand
    {
        public Trade() : base("/trade", false, true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            return false;
        }
    }

    public class TradeAccept : BaseChatCommand
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

    public class TradeReject : BaseChatCommand
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

    public class TradeGive : BaseChatCommand
    {

        public TradeGive() : base("/trade give", true)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (args.Length < 3)
            {
                Chat.Send(ply, "Not enough arguments. Usage:");
                Chat.Send(ply, "/trade give <playername> <myitemid> <myitemamount>");
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
                Chat.Send(ply, "Invalid argument. Usage:");
                Chat.Send(ply, "/trade give <playername> <myitemid> <myitemamount>");
                return true;
            }
            Managers.PlayerManager.tradeGive(ply, Players.GetPlayer(target), giveid, giveamt);
            return true;
        }
    }

    public class TradeSend : BaseChatCommand
    {
        public TradeSend() : base("/trade send", true)
        {

        }

        override protected bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (args.Length < 5)
            {
                Chat.Send(ply, "Not enough arguments. Usage:");
                Chat.Send(ply, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>");
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
                Chat.Send(ply, "Invalid argument. Usage:");
                Chat.Send(ply, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>");
                return true;
            }
            Managers.PlayerManager.notifyTrade(ply, Players.GetPlayer(target), giveid, giveamt, takeid, takeamt);
            return true;
        }
    }
}
