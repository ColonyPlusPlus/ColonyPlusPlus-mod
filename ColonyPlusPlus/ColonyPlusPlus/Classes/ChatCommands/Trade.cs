using ChatCommands;
using NPC;
using Permissions;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class Trade : IChatCommand
    {
        private NetworkID GetSubject(NetworkID self, string[] splits)
        {
            Players.Player player;
            if (splits.Length < 6)
            {
                Chat.Send(self, "Missing argument. Usage:");
                Chat.Send(self, "/trade <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>");
                return NetworkID.Invalid;
            }
            if (Players.TryMatchName(splits[1], out player))
            {
                return player.ID;
            }
            Chat.Send(self, $"Failed to find player named [{splits[1]}]", ChatSenderType.Server);
            return NetworkID.Invalid;
        }

        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/trade "));

        private bool ProcessTrade(NetworkID id, string chatItem)
        {
            string[] splits = chatItem.Split(' ');
            NetworkID target = GetSubject(id, splits);
            if (target == NetworkID.Invalid) return true;
            ushort takeid = 0;
            int takeamt = 0;
            ushort giveid = 0;
            int giveamt = 0;
            bool sucessful = UInt16.TryParse(splits[2], out takeid);
            sucessful = sucessful && Int32.TryParse(splits[3], out takeamt);
            sucessful = sucessful && UInt16.TryParse(splits[4], out giveid);
            sucessful = sucessful && Int32.TryParse(splits[5], out giveamt);
            if (!sucessful)
            {
                Chat.Send(id, "Invalid argument. Usage:");
                Chat.Send(id, "/trade <playername> <myitemid> <myitemamount> <theiritemid> <theiritemamount>");
                return true;
            }
            Managers.PlayerManager.notifyTrade(Players.GetPlayer(id), Players.GetPlayer(target), giveid, giveamt, takeid, takeamt);
            return true;
        }



        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            if (chatItem.StartsWith("/trade "))
            {
                return this.ProcessTrade(id, chatItem);
            }
            return false;
        }
    }
}

