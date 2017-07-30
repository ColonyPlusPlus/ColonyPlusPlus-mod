using Permissions;
using System;
using ChatCommands;
using NPC;
using Permissions;
using Pipliz;
using ColonyPlusPlus.Classes.Helpers;
using System;

namespace ColonyPlusPlus.Classes.ChatCommands
{
    class ChunkCommands : IChatCommand
    {
        public bool IsCommand(string chatItem) =>
            (chatItem.StartsWith("/chunk"));

        public bool TryDoCommand(NetworkID id, string chatItem)
        {
            if (chatItem.StartsWith("/chunk"))
            {
                string[] s = chatItem.Split(' ');
                if(s.Length >= 2)
                {
                    if (s[1] == "claim")
                    {

                        return this.ProcessClaimChunk(id, chatItem);
                    }
                    else if (s[1] == "unclaim")
                    {
                        return this.ProcessUnclaimChunk(id, chatItem);
                    }
                    else if (s[1] == "delete")
                    {
                        return this.ProcessDeleteChunk(id, chatItem);
                    }
                } else
                {
                    Chat.send(id, "Correct usage: /chunk {action} where action can be claim, unclaim, or delete", Chat.ChatColour.lime, Chat.ChatStyle.bold);
                }
                
            }
            return false;
        }

        private bool ProcessClaimChunk(NetworkID id, string chatItem)
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

        private bool ProcessUnclaimChunk(NetworkID id, string chatItem)
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
                    // chunk already owned
                    Chat.send(id, "Unable to unclaim chunk", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }



            }


            return true;
        }

        private bool ProcessDeleteChunk(NetworkID id, string chatItem)
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
                    // chunk already owned
                    Chat.send(id, "Unable to unclaim chunk", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }



            }


            return true;
        }
    }
}
