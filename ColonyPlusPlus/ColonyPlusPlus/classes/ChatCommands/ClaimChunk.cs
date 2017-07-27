using ChatCommands;
using NPC;
using Permissions;
using Pipliz;
using Pipliz.Chatting;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{

    public class ClaimChunk : IChatCommand
    {
 
        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/claimchunk"));

        private bool ProcessCreative(NetworkID id, string chatItem)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "chunk.claim"))
            {
                // get the current chunk
                Players.Player p = Players.GetPlayer(id);

                int playerX = Pipliz.Math.RoundToInt(p.Position.x);
                int playerY = Pipliz.Math.RoundToInt(p.Position.y);
                int playerZ = Pipliz.Math.RoundToInt(p.Position.z);

                Chunk c = World.GetChunk(new Vector3Int(playerX, playerY, playerZ));

                c.

                p.Position.
                Chat.Send(id, "Enabled Creative Mode", ChatSenderType.Server);
            }


            return true;
        }



        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            if (chatItem.StartsWith("/creative"))
            {
                return this.ProcessCreative(id, chatItem);
            }
            return false;
        }
    }
}

