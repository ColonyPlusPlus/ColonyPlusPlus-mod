using Permissions;
using System;
using ChatCommands;
using NPC;
using Pipliz;
using ColonyPlusPlus.Classes.Helpers;

namespace ColonyPlusPlus.Classes.CPPChatCommands
{
    class Chunk : BaseChatCommand
    {
        public ChunkCommand() : base("/chunk", false, true)
        {

        }

        protected override bool RunCommand(NetworkID id, string[] args, NetworkID target)
        {
            return false;
        }
    }

    class ChunkClaim : BaseChatCommand
    {
        public ChunkClaim() : base("/chunk claim")
        {

        }

        protected override bool RunCommand(NetworkID id, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "chunk.claim"))
            {
                // get the current chunk
                Players.Player p = Players.GetPlayer(id);

                int playerX = Pipliz.Math.RoundToInt(p.Position.x);
                int playerY = Pipliz.Math.RoundToInt(p.Position.y);
                int playerZ = Pipliz.Math.RoundToInt(p.Position.z);

                Vector3Int position = new Vector3Int(playerX, playerY, playerZ);

                if (Managers.WorldManager.claimChunk(position, p.ID))
                {
                    Vector3Int chunkPos = position.ToChunk();
                    int owned = Managers.WorldManager.getOwnedChunkCount(p.ID);

                    Chat.send(id, String.Format("Claimed chunk: {0}, {1}, {2}", chunkPos.x, chunkPos.y, chunkPos.z), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                    Chat.send(id, String.Format("You now own {0} chunks.", owned), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                }
                else
                {
                    // chunk already owned
                    Chat.send(id, "Unable to claim chunk", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }
                
            }

            return true;
        }
    }

    class ChunkUnClaim : BaseChatCommand
    {
        public ChunkUnClaim() : base("/chunk unclaim")
        {

        }

        protected override bool RunCommand(NetworkID id, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "chunk.claim"))
            {
                // get the current chunk
                Players.Player p = Players.GetPlayer(id);

                int playerX = Pipliz.Math.RoundToInt(p.Position.x);
                int playerY = Pipliz.Math.RoundToInt(p.Position.y);
                int playerZ = Pipliz.Math.RoundToInt(p.Position.z);

                Vector3Int position = new Vector3Int(playerX, playerY, playerZ);

                if (Managers.WorldManager.unclaimChunk(position, p.ID))
                {
                    Vector3Int chunkPos = position.ToChunk();
                    int owned = Managers.WorldManager.getOwnedChunkCount(p.ID);

                    Chat.send(id, String.Format("Unclaimed chunk: {0}, {1}, {2}", chunkPos.x, chunkPos.y, chunkPos.z), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                    Chat.send(id, String.Format("You now own {0} chunks.", owned), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                }
                else
                {
                    // chunk not owned
                    Chat.send(id, "Unable to unclaim chunk", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }
                
            }
            
            return true;
        }
    }

    class ChunkDelete : BaseChatCommand
    {
        public ChunkDelete() : base("/chunk delete")
        {

        }

        protected override bool RunCommand(NetworkID id, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(id, "chunk.delete"))
            {
                // get the current chunk
                Players.Player p = Players.GetPlayer(id);

                int playerX = Pipliz.Math.RoundToInt(p.Position.x);
                int playerY = Pipliz.Math.RoundToInt(p.Position.y);
                int playerZ = Pipliz.Math.RoundToInt(p.Position.z);

                Vector3Int position = new Vector3Int(playerX, playerY, playerZ);

                if (Managers.WorldManager.unclaimChunk(position, p.ID))
                {
                    Vector3Int chunkPos = position.ToChunk();
                    int owned = Managers.WorldManager.getOwnedChunkCount(p.ID);

                    Chat.send(id, String.Format("Unclaimed chunk: {0}, {1}, {2}", chunkPos.x, chunkPos.y, chunkPos.z), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                    Chat.send(id, String.Format("You now own {0} chunks.", owned), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                }
                else
                {
                    // chunk not owned
                    Chat.send(id, "Unable to unclaim chunk", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }
                
            }
            
            return true;
        }
    }
}
