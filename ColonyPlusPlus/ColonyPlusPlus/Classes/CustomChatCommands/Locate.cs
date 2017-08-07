﻿using Pipliz.Chatting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    public class Locate : BaseChatCommand
    {
        public Locate() : base("/locate", true)
        {
        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            var player = Players.GetPlayer(target);
            var status = player.IsConnected ? "online" : "offline";
            Chat.Send(ply, $"{player.Name} is {status} and was last seen at x:{player.Position.x} y:{player.Position.y} z:{player.Position.z}");
            return true;
        }
    }

    public class LocateBanner : BaseChatCommand
    {
        public LocateBanner() : base("/locate banner", true)
        {
        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            var player = Players.GetPlayer(target);

            var banner = (from b in BannerTracker.GetBanners()
                where b.Owner == player
                select b).FirstOrDefault();

            Chat.Send(ply,
                banner != null
                    ? $"{player.Name} has a banner at x:{banner.KeyLocation.x} y:{banner.KeyLocation.y} z:{banner.KeyLocation.z}"
                    : $"{player.Name} doesnt have a banner");

            return true;
        }
    }
}
