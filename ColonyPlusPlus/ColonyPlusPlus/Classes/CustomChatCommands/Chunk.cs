﻿using Permissions;
using System;
using ChatCommands;
using NPC;
using Pipliz;
using ColonyPlusPlus.Classes.Helpers;
using System.Collections.Generic;

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
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.claim") && Classes.Managers.ConfigManager.getConfigBoolean("chunks.enabled"))
            {
                int maxClaims = Classes.Managers.ConfigManager.getConfigInt("chunks.maxclaims");

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
                        Chat.send(ply, string.Format("You now own {0} chunks (max {1}).", owned, maxClaims), Chat.ChatColour.lime, Chat.ChatStyle.bold);
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

    public class ChunkList : BaseChatCommand
    {
        public ChunkList() : base("/chunk list")
        {

        }

        protected override bool RunCommand(Players.Player ply, string[] args, NetworkID target)
        {
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.list") && Classes.Managers.ConfigManager.getConfigBoolean("chunks.enabled"))
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

                    Chat.send(ply, ownedChunks, Chat.ChatColour.cyan, Chat.ChatStyle.bold);
                    
                }
                else
                {
                    Chat.send(ply, "You own no chunks", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }

            }
            else
            {
                Chat.send(ply, "You cannot claim chunks", Chat.ChatColour.red, Chat.ChatStyle.bold);
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
            if (PermissionsManager.CheckAndWarnPermission(ply, "chunk.info") && Classes.Managers.ConfigManager.getConfigBoolean("chunks.enabled"))
            {
                Vector3Int pos = Managers.WorldManager.positionToVector3Int(ply.Position).ToChunk();
                string chunkName = Managers.WorldManager.positionToString(pos);
                if (Managers.WorldManager.ChunkDataList.ContainsKey(chunkName))
                {
                    Data.ChunkData c = Managers.WorldManager.ChunkDataList[chunkName];
                    Chat.send(ply, String.Format("Chunk data for chunk: {0}", chunkName), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                    Chat.send(ply, String.Format("Currently owned: {0}", c.hasOwner()), Chat.ChatColour.lime, Chat.ChatStyle.bold);

                    if(c.hasOwner())
                    {

                        Chat.send(ply, String.Format("Currently owned by: {0}", Players.GetPlayer(c.getOwner()).Name), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                    }

                    string prevOwners = "";

                    foreach (NetworkID n in c.ownerHistory)
                    {
                        prevOwners += Players.GetPlayer(n).Name + ", "; 
                    }

                    Chat.send(ply, String.Format("Previous Owners ({0}): {1}", c.ownerHistory.Count, prevOwners), Chat.ChatColour.lime, Chat.ChatStyle.bold);
                } else
                {
                    Chat.send(ply, "No chunk data", Chat.ChatColour.red, Chat.ChatStyle.bold);
                }
               
            }
            else
            {
                Chat.send(ply, "You cannot check chunk info", Chat.ChatColour.red, Chat.ChatStyle.bold);
            }

            return true;
        }
    }

}
