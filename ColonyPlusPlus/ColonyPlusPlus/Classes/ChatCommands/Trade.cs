using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class Trade : IChatCommand
    {
        
        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/trade send"));

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
                Chat.Send(id, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>");
                return true;
            }
            ushort takeid = 0;
            int takeamt = 0;
            ushort giveid = 0;
            int giveamt = 0;
            bool sucessful = UInt16.TryParse(splits[1], out takeid);
            if (!sucessful)
            {
                sucessful = sucessful || ItemTypes.IndexLookup.TryGetIndex(splits[1], out takeid);
            }
            sucessful = sucessful && Int32.TryParse(splits[2], out takeamt);
            bool giveSucessful = UInt16.TryParse(splits[3], out giveid);
            if (!giveSucessful)
            {
                giveSucessful = giveSucessful || ItemTypes.IndexLookup.TryGetIndex(splits[3], out giveid);
            }
            sucessful = sucessful && giveSucessful;
            sucessful = sucessful && Int32.TryParse(splits[4], out giveamt);
            if (!sucessful)
            {
                Chat.Send(id, "Invalid argument. Usage:");
                Chat.Send(id, "/trade send <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>");
                return true;
            }
            Managers.PlayerManager.notifyTrade(Players.GetPlayer(id), Players.GetPlayer(target), giveid, giveamt, takeid, takeamt);
            return true;
        }
        
        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            return this.ProcessTrade(id, chatItem);
        }
    }
}

