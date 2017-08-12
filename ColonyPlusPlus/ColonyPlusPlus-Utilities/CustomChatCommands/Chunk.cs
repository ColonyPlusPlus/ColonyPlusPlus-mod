using Permissions;
using System;
using Pipliz;
using ColonyPlusPlusUtilities;

namespace ColonyPlusPlusUtilities.CustomChatCommands
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
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.claim") && ColonyAPI.Managers.ConfigManager.getConfigBoolean("ColonyPlusPlusUtilities", "chunks.enabled"))
            {
                int maxClaims = ColonyAPI.Managers.ConfigManager.getConfigInt("ColonyPlusPlusUtilities", "chunks.maxclaims");

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

                        ColonyAPI.Helpers.Chat.sendSilent(ply, string.Format("Claimed chunk: {0}, {1}, {2}", chunkPos.x, chunkPos.y, chunkPos.z), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                        ColonyAPI.Helpers.Chat.sendSilent(ply, string.Format("You now own {0} chunks (max {1}).", owned, maxClaims), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                    }
                    else
                    {
                        // chunk already owned
                        ColonyAPI.Helpers.Chat.sendSilent(ply, "Unable to claim chunk", ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                    }
                } else {
                    ColonyAPI.Helpers.Chat.sendSilent(ply, String.Format("You already own the maximum number of chunks ({0}), please unclaim one to claim another.", maxClaims), ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                }
                
            } else {
                ColonyAPI.Helpers.Chat.sendSilent(ply, "You cannot claim chunks", ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
            }
            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusUtilities", ply.Name + " attempted to use /chunk claim!");
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

                    ColonyAPI.Helpers.Chat.sendSilent(ply, string.Format("Unclaimed chunk: {0}, {1}, {2}", chunkPos.x, chunkPos.y, chunkPos.z), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                    ColonyAPI.Helpers.Chat.sendSilent(ply, string.Format("You now own {0} chunks.", owned), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                }
                else
                {
                    // chunk not owned
                    ColonyAPI.Helpers.Chat.sendSilent(ply, "Unable to unclaim chunk", ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                }
            }
            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusUtilities", ply.Name + " attempted to use /chunk unclaim!");
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

                    ColonyAPI.Helpers.Chat.send(ply, string.Format("Chunk Owner Deleted ({0}, {1}, {2})", chunkPos.x, chunkPos.y, chunkPos.z), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                }
                else
                {
                    // chunk not owned
                    ColonyAPI.Helpers.Chat.sendSilent(ply, "Unable to unclaim chunk", ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                }

            }
            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusUtilities", ply.Name + " attempted to use /chunk delete!");
            return true;
        }
    }

    public class ChunkList : BaseChatCommand
    {
        public ChunkList() : base("/chunk list")
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.list") && ColonyAPI.Managers.ConfigManager.getConfigBoolean("ColonyPlusPlusUtilities", "chunks.enabled"))
            {

                if (Managers.WorldManager.getOwnedChunkCount(ply.ID) > 0)
                {
                    string ownedChunks = "You own " + Managers.WorldManager.getOwnedChunkCount(ply.ID) + " chunks: ";

                    foreach (Data.ChunkData c in Managers.WorldManager.ChunkDataList.Values)
                    {
                        if (c.getOwner() == ply.ID)
                        {
                            ownedChunks += "[" + Managers.WorldManager.positionToString(c.location.ToChunk()) + "], ";
                        }
                    }

                    ColonyAPI.Helpers.Chat.sendSilent(ply, ownedChunks, ColonyAPI.Helpers.Chat.ChatColour.cyan, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                    
                }
                else
                {
                    ColonyAPI.Helpers.Chat.sendSilent(ply, "You own no chunks", ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                }

            }
            else
            {
                ColonyAPI.Helpers.Chat.sendSilent(ply, "You cannot claim chunks", ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
            }

            return true;
        }
    }

    public class ChunkInfo : BaseChatCommand
    {
        public ChunkInfo() : base("/chunk info")
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.info") && ColonyAPI.Managers.ConfigManager.getConfigBoolean("ColonyPlusPlusUtilities", "chunks.enabled"))
            {
                Vector3Int pos = Managers.WorldManager.positionToVector3Int(ply.Position).ToChunk();
                string chunkName = Managers.WorldManager.positionToString(pos);
                if (Managers.WorldManager.ChunkDataList.ContainsKey(chunkName))
                {
                    Data.ChunkData c = Managers.WorldManager.ChunkDataList[chunkName];
                    ColonyAPI.Helpers.Chat.sendSilent(ply, String.Format("Chunk data for chunk: {0}", chunkName), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                    ColonyAPI.Helpers.Chat.sendSilent(ply, String.Format("Currently owned: {0}", c.hasOwner()), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);

                    if(c.hasOwner())
                    {

                        ColonyAPI.Helpers.Chat.sendSilent(ply, String.Format("Currently owned by: {0}", Players.GetPlayer(c.getOwner()).Name), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                    }

                    string prevOwners = "";

                    foreach (NetworkID n in c.ownerHistory)
                    {
                        prevOwners += Players.GetPlayer(n).Name + ", "; 
                    }

                    ColonyAPI.Helpers.Chat.sendSilent(ply, String.Format("Previous Owners ({0}): {1}", c.ownerHistory.Count, prevOwners), ColonyAPI.Helpers.Chat.ChatColour.lime, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                } else
                {
                    ColonyAPI.Helpers.Chat.sendSilent(ply, "No chunk data", ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
                }
               
            }
            else
            {
                ColonyAPI.Helpers.Chat.sendSilent(ply, "You cannot check chunk info", ColonyAPI.Helpers.Chat.ChatColour.red, ColonyAPI.Helpers.Chat.ChatStyle.bold);
            }

            return true;
        }
    }

}
