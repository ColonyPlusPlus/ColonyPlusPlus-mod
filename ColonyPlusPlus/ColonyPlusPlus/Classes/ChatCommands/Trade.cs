using ChatCommands;
using Pipliz.Chatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.ChatCommands
{
    class Trade : IChatCommand
    {
        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/trade"));

        public bool TryDoCommand(NetworkID owner, string chat)
        {
            return this.SendItems(owner, chat);
        }

        private static NetworkID GetSubject(NetworkID self, string[] splits)
        {
            Players.Player player;
            if (splits.Length < 3)
            {
                return self;
            }
            if (Players.TryMatchName(splits[2], out player))
            {
                return player.ID;
            }
            Chat.Send(self, $"Failed to find player named [{splits[2]}]", ChatSenderType.Server);
            return NetworkID.Invalid;
        }

        private bool SendItems(NetworkID id, string chatItem)
        {
            string[] secs = chatItem.Split(' ');
            if (secs.Count() == 4)
            {
                Players.Player player;
                if (Players.TryMatchName(secs[1], out player))
                {
                    string item = secs[2];
                    int amt;
                    if (Int32.TryParse(secs[3], out amt))
                    {
                        Stockpile playerStockpile = Stockpile.GetStockPile(id);
                        Stockpile targetStockpile;
                        Stockpile.TryGetStockpile(player.ID, out targetStockpile);
                        if (playerStockpile.Remove(ItemTypes.IndexLookup.GetIndex(item), amt))
                        {
                            if (targetStockpile.Add(ItemTypes.IndexLookup.GetIndex(item), amt))
                            {
                                Chat.Send(player.ID, "Was given " + amt + " " + item);
                                Chat.Send(id, "Just sent " + amt + " " + item);
                            }
                            return true;
                        }
                    }
                }
            }
            Chat.Send(id, "Invalid argument. Usage:");
            Chat.Send(id, "/trade <playername> <myitemid> <myitemamount>");
            return false;
        }
    }
}
