using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class TradeGive : IChatCommand
    {

        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/trade give"));

        private bool ProcessTrade(NetworkID id, string chatItem)
        {
            string[] presplit = chatItem.Split(' ');
            string[] arguments = new string[presplit.Length - 2];
            for (int i = 0; i < arguments.Length; i++)
            {
                arguments[i] = presplit[i + 2];
            }
            string[] splits;
            NetworkID target = Utilities.GetSubject(arguments, out splits);
            if (target == NetworkID.Invalid)
            {
                Chat.Send(id, "Player not found. Usage:");
                Chat.Send(id, "/trade give <playername> <myitemid> <myitemamount>");
                return true;
            }
            ushort giveid = 0;
            int giveamt = 0;
            bool sucessful = UInt16.TryParse(splits[1], out giveid);
            if (!sucessful)
            {
                sucessful = sucessful || ItemTypes.IndexLookup.TryGetIndex(splits[1], out giveid);
            }
            sucessful = sucessful && Int32.TryParse(splits[2], out giveamt);
            if (!sucessful)
            {
                Chat.Send(id, "Invalid argument. Usage:");
                Chat.Send(id, "/trade give <playername> <myitemid> <myitemamount>");
                return true;
            }
            Managers.PlayerManager.tradeGive(Players.GetPlayer(id), Players.GetPlayer(target), giveid, giveamt);
            return true;
        }

        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            return this.ProcessTrade(id, chatItem);
        }
    }
}

