using Pipliz.Chatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.CPPChatCommands
{
    class Trade : BaseChatCommand
    {
        public Trade() : base("/trade", false, true)
        {

        }

        protected override bool RunCommand(NetworkID id, string[] args, NetworkID target)
        {
            return false;
        }
    }

    class TradeAccept : BaseChatCommand
    {
        public TradeAccept() : base("/trade accept", false)
        {

        }

        override protected bool RunCommand(NetworkID id, string[] args, NetworkID target)
        {
            Managers.PlayerManager.acceptTrade(Players.GetPlayer(id));
            return true;
        }
    }

    public class TradeReject : BaseChatCommand
    {
        public TradeReject() : base("/trade reject", false)
        {

        }

        override protected bool RunCommand(NetworkID id, string[] args, NetworkID target)
        {
            Managers.PlayerManager.rejectTrade(Players.GetPlayer(id));
            return true;
        }
    }

    class TradeGive : BaseChatCommand
    {

        public TradeGive() : base("/trade give", true)
        {

        }

        override protected bool RunCommand(NetworkID id, string[] args, NetworkID target)
        {
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
                Chat.Send(id, "Invalid argument. Usage:");
                Chat.Send(id, "/trade give <playername> <myitemid> <myitemamount>");
                return true;
            }
            Managers.PlayerManager.tradeGive(Players.GetPlayer(id), Players.GetPlayer(target), giveid, giveamt);
            return true;
        }
    }

    public class TradeSend : BaseChatCommand
    {
        public TradeSend() : base("/trade send", true)
        {

        }

        override protected bool RunCommand(NetworkID id, string[] arguments, NetworkID target)
        {
            ushort takeid = 0;
            int takeamt = 0;
            ushort giveid = 0;
            int giveamt = 0;
            bool sucessful = UInt16.TryParse(arguments[1], out takeid);
            if (!sucessful)
            {
                sucessful = sucessful || ItemTypes.IndexLookup.TryGetIndex(arguments[1], out takeid);
            }
            sucessful = sucessful && Int32.TryParse(arguments[2], out takeamt);
            bool giveSucessful = UInt16.TryParse(arguments[3], out giveid);
            if (!giveSucessful)
            {
                giveSucessful = giveSucessful || ItemTypes.IndexLookup.TryGetIndex(arguments[3], out giveid);
            }
            sucessful = sucessful && giveSucessful;
            sucessful = sucessful && Int32.TryParse(arguments[4], out giveamt);
            if (!sucessful)
            {
                Chat.Send(id, "Invalid argument. Usage:");
                Chat.Send(id, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>");
                return true;
            }
            Managers.PlayerManager.notifyTrade(Players.GetPlayer(id), Players.GetPlayer(target), giveid, giveamt, takeid, takeamt);
            return true;
        }
    }
}
