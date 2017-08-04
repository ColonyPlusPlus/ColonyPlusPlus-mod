using Permissions;
using System;
using ChatCommands;
using NPC;
using Pipliz;
using ColonyPlusPlus.Classes.Helpers;

namespace ColonyPlusPlus.Classes.CustomChatCommands
{
    public class Chunk : BaseChatCommand
    {
        public Chunk() : base("/chunk", false, true)
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            return false;
        }
    }

    public class ChunkClaim : BaseChatCommand
    {
        public ChunkClaim() : base("/chunk claim")
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.claim") && Classes.Managers.ConfigManager.getConfigBoolean("chunk.allowclaiming"))
            {
                int maxClaims = Classes.Managers.ConfigManager.getConfigInt("chunk.maxclaims");

                if( Managers.WorldManager.getOwnedChunkCount(ply.ID) < maxClaims) {
                    // get the current chunk
                    int playerX = Pipliz.Math.RoundToInt(ply.Position.x);
                    int playerY = Pipliz.Math.RoundToInt(ply.Position.y);
                    int playerZ = Pipliz.Math.RoundToInt(ply.Position.z);

                    Vector3Int position = new Vector3Int(playerX, playerY, playerZ);

                    if (Managers.WorldManager.claimChunk(position, ply.ID))
                    {
                        Vector3Int chunkPos = position.ToChunk();
                        int owned = Managers.WorldManager.getOwnedChunkCount(ply.ID);

                        Chat.send(ply, string.Format("Claimed chunk: {0}, {1}, {2}", chunkPos.x, chunkPos.y, chunkPos.z), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                        Chat.send(ply, string.Format("You now own {0} chunks.", owned), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                    }
                    else
                    {
                        // chunk already owned
                        Chat.send(ply, "Unable to claim chunk", Chat.ChatColour.red, Chat.ChatStyle.bold);
                    }
                } else {
                    Chat.send(ply, String.Format("You already own the maximum number of chunks ({0}), please unclaim one to claim another.", maxClaims), Chat.ChatColour.red, Chat.ChatStyle.bold);
                }
                
            } else {
                Chat.send(ply, "You cannot claim chunks", Chat.ChatColour.red, Chat.ChatStyle.bold);
            }

            return true;
        }
    }

    public class ChunkUnClaim : BaseChatCommand
    {
        public ChunkUnClaim() : base("/chunk unclaim")
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.claim"))
            {
                // get the current chunk
                int playerX = Pipliz.Math.RoundToInt(ply.Position.x);
                int playerY = Pipliz.Math.RoundToInt(ply.Position.y);
                int playerZ = Pipliz.Math.RoundToInt(ply.Position.z);

                Vector3Int position = new Vector3Int(playerX, playerY, playerZ);

                if (Managers.WorldManager.unclaimChunk(position, ply.ID))
                {
                    Vector3Int chunkPos = position.ToChunk();
                    int owned = Managers.WorldManager.getOwnedChunkCount(ply.ID);

                    Chat.send(ply, string.Format("Unclaimed chunk: {0}, {1}, {2}", chunkPos.x, chunkPos.y, chunkPos.z), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                    Chat.send(ply, string.Format("You now own {0} chunks.", owned), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                }
                else
                {
                    // chunk not owned
                    Chat.send(ply, "Unable to unclaim chunk", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }
                
            }
            
            return true;
        }
    }

    public class ChunkDelete : BaseChatCommand
    {
        public ChunkDelete() : base("/chunk delete")
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.delete"))
            {
                // get the current chunk
                int playerX = Pipliz.Math.RoundToInt(ply.Position.x);
                int playerY = Pipliz.Math.RoundToInt(ply.Position.y);
                int playerZ = Pipliz.Math.RoundToInt(ply.Position.z);

                Vector3Int position = new Vector3Int(playerX, playerY, playerZ);

                if (Managers.WorldManager.unclaimChunk(position, ply.ID, true))
                {
                    Vector3Int chunkPos = position.ToChunk();

                    Chat.send(ply, string.Format("Chunk Owner Deleted ({0}, {1}, {2})", chunkPos.x, chunkPos.y, chunkPos.z), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                }
                else
                {
                    // chunk not owned
                    Chat.send(ply, "Unable to unclaim chunk", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }
                
            }
            
            return true;
        }
    }
}
