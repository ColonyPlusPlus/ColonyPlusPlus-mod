﻿using Permissions;
using Chat = ColonyPlusPlus.Classes.Helpers.Chat;
using System.Linq;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    public class Locate : BaseChatCommand
    {
        public Locate() : base("/locate", true)
        {
        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "locate"))
            {
                var player = Players.GetPlayer(targets[0]);
                var status = player.IsConnected ? "online" : "offline";

                Chat.sendSilent(ply,
                    $"{player.Name} is {status} and was last seen at x:{player.Position.x} y:{player.Position.y} z:{player.Position.z}", Chat.ChatColour.magenta);

            }

            return true;
        }
    }

    public class LocateBanner : BaseChatCommand
    {
        public LocateBanner() : base("/locate banner", true)
        {
        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID[] targets)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "locate"))
            {
                var player = Players.GetPlayer(targets[0]);

                var banner = (from b in BannerTracker.GetBanners()
                    where b.Owner == player
                    select b).FirstOrDefault();

                Chat.sendSilent(ply,
                    banner != null
                        ? $"{player.Name} has a banner at x:{banner.KeyLocation.x} y:{banner.KeyLocation.y} z:{banner.KeyLocation.z}"
                        : $"{player.Name} doesn't have a banner",Chat.ChatColour.magenta);

            }
            return true;
        }
    }
}
