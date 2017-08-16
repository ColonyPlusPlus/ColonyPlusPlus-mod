using System;
using System.Collections.Generic;
using Pipliz;
using System.IO;
using Pipliz.JSON;
using Steamworks;
using UnityEngine;
using Permissions;

namespace ColonyPlusPlusUtilities.Managers
{
    public static class WorldManager
    {
        public static Dictionary<string, Data.ChunkData> ChunkDataList = new Dictionary<string, Data.ChunkData>();

        private static bool worldManagerLoaded = false;


        public static bool claimChunk(Vector3Int position, NetworkID playerid, bool isSpawn = false)
        {
            Vector3Int p = position.ToChunk();
            string chunkname = ColonyAPI.Managers.WorldManager.XZPositionToString(p);
            if (ChunkDataList.ContainsKey(chunkname))
            {
                Data.ChunkData c = ChunkDataList[chunkname];

                bool result = c.setOwner(playerid);
                SaveJSON();

                return result;
            }
            else
            {
                Data.ChunkData c = new Data.ChunkData(p, true, playerid, new List<NetworkID>() { playerid }, isSpawn);

                ChunkDataList.Add(chunkname, c);
                SaveJSON();

                return true;
            }
        }

        public static bool unclaimChunk(Vector3Int position, NetworkID playerid, bool force = false)
        {
            Vector3Int p = position.ToChunk();
            string chunkname = ColonyAPI.Managers.WorldManager.XZPositionToString(p);

            if (ChunkDataList.ContainsKey(chunkname))
            {
                Data.ChunkData c = ChunkDataList[chunkname];
                if (c.getOwner() == playerid || force)
                {
                    bool result = c.removeOwner();
                    SaveJSON();
                    return result;
                }
                return false;

            }
            else
            {
                return false;
            }
        }

        public static int getOwnedChunkCount(NetworkID p)
        {
            int owned = 0;

            foreach (string k in ChunkDataList.Keys)
            {
                if (ChunkDataList[k].getOwner() == p)
                {
                    owned += 1;
                }
            }

            return owned;
        }




        private static string GetJSONPath()
        {
            return "gamedata/savegames/" + ServerManager.WorldName + "/cppchunkdata.json";
        }


        // Saving the crop tracker
        public static void SaveJSON()
        {
            try
            {
                string jSONPath = GetJSONPath();
                ColonyAPI.Helpers.Utilities.MakeDirectoriesIfNeeded(jSONPath);
                if (ChunkDataList.Count == 0)
                {
                    File.Delete(jSONPath);
                }
                else
                {

                    // make a JSON node
                    JSONNode rootnode = new JSONNode(NodeType.Array);

                    // then go through stuff
                    foreach (Data.ChunkData c in ChunkDataList.Values)
                    {
                        //if(c.getSpawn()) { continue; }
                        // build a child node
                        JSONNode child = new JSONNode(NodeType.Object);

                        JSONNode history = new JSONNode(NodeType.Array);
                        foreach (NetworkID n in c.ownerHistory)
                        {
                            JSONNode j = new JSONNode(NodeType.Object);
                            j.SetAs("id", n.steamID.m_SteamID);
                            history.AddToArray(j);
                        }

                        // Create the JSON
                        child.SetAs("location", (JSONNode)c.location);
                        child.SetAs("chunkID", ColonyAPI.Managers.WorldManager.XZPositionToString(c.location));
                        child.SetAs("owned", c.hasOwner());
                        child.SetAs("playerID", c.getOwner().steamID.m_SteamID);
                        child.SetAs("ownerHistory", history);

                        rootnode.AddToArray(child);
                    }

                    Pipliz.JSON.JSON.Serialize(jSONPath, rootnode);

                }
            }
            catch (Exception exception2)
            {
                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Utilities", "Exception in saving all Owned Chunks:" + exception2.Message);
            }
        }


        public static void LoadJSON()
        {
            try
            {

                JSONNode array;
                if (Pipliz.JSON.JSON.Deserialize(GetJSONPath(), out array, false))
                {

                    if (array != null)
                    {
                        int chunksloaded = 0;
                        foreach (JSONNode node in array.LoopArray())
                        {
                            try
                            {
                                // recapture location
                                Pipliz.Vector3Int location = new Pipliz.Vector3Int();
                                location = (Pipliz.Vector3Int)node["location"];

                                // recapture instance class
                                string chunkID = node["chunkID"].GetAs<string>();

                                Data.ChunkData instanceclass;

                                bool owned = node["owned"].GetAs<bool>();
                                ulong playerID = node["playerID"].GetAs<ulong>();
                                JSONNode history = node["ownerHistory"].GetAs<JSONNode>();
                                List<NetworkID> ownerHistory = new List<NetworkID>();

                                foreach (JSONNode j in history.LoopArray())
                                {
                                    ownerHistory.Add(new NetworkID(new CSteamID(j.GetAs<ulong>("id"))));
                                }

                                if (playerID > 0)
                                {
                                    instanceclass = new Data.ChunkData(location, owned, new NetworkID(new CSteamID(playerID)), ownerHistory);

                                    ChunkDataList.Add(chunkID, instanceclass);

                                    chunksloaded += 1;
                                }


                            }
                            catch (Exception exception)
                            {
                                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Utilities", "Exception loading a wheat block;" + exception.Message);
                            }
                        }

                        ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Utilities", "Loaded Chunk Data (" + chunksloaded + " chunks)");

                    }
                    else
                    {
                        ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Utilities", "Loading Chunk Data Returned 0 results");
                    }
                }
                else
                {
                    ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Utilities", "Found no chunk data (read error?)");
                }

            }
            catch (Exception exception2)
            {
                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Utilities", "Exception in loading all Chunk Data:" + exception2.Message);
            }

            worldManagerLoaded = true;
        }


        public static bool AllowPlaceBlock(ModLoader.OnTryChangeBlockUserData d)
        {
            if (PermissionsManager.CheckAndWarnPermission(Players.GetPlayer(d.requestedBy.ID), "world.admin"))
            {
                return true;
            }

            // Check permissions
            if (PermissionsManager.CheckAndWarnPermission(Players.GetPlayer(d.requestedBy.ID), "world.build"))
            {
                //Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You have build permissions");

                // first check if near spawn
                if (allowBlockFarEnoughFromSpawn(d))
                {
                    //Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You are far enough from spawn");
                    // what about chunk ownership
                    if (allowBlockPlaceChunkOwnership(d))
                    {
                        if (d.TypeNew == ItemTypes.IndexLookup.GetIndex("water"))
                        {
                            if (PermissionsManager.CheckAndWarnPermission(Players.GetPlayer(d.requestedBy.ID), "world.spawnbuilder"))
                            {
                                return true;
                            }
                            return false;
                        }
                        //Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You own the chunk");
                        return true;
                    }
                    else
                    {
                        if (d.TypeNew == ItemTypes.IndexLookup.GetIndex("banner"))
                        {
                            string ChunkID = ColonyAPI.Managers.WorldManager.XZPositionToString(d.voxelHit.ToChunk());
                            if (Managers.WorldManager.ChunkDataList.ContainsKey(ChunkID))
                            {
                                Data.ChunkData cd = Managers.WorldManager.ChunkDataList[ChunkID];
                                if (cd.hasOwner())
                                {
                                    NetworkID id = cd.getOwner();
                                    if (id == d.requestedBy.ID)
                                    {
                                        return true;
                                    }
                                    return false;
                                }
                            }
                        }
                        ColonyAPI.Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You don't own the chunk");
                        return false;
                    }
                }
                else
                {
                    //This section is for spawn.
                    if (PermissionsManager.CheckAndWarnPermission(Players.GetPlayer(d.requestedBy.ID), "spawnbuilder"))
                    {
                        //Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You aren't far enough from spawn, but you are admin");
                        return true;
                    }
                    else
                    {
                        ColonyAPI.Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You aren't far enough from spawn");
                        return false;
                    }
                }
            }
            else
            {
                ColonyAPI.Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You don't have build permissions");
                return false;
            }







        }

        private static bool allowBlockFarEnoughFromSpawn(ModLoader.OnTryChangeBlockUserData d)
        {
            if (ColonyAPI.Managers.ConfigManager.getConfigBoolean("ColonyPlusPlus-Utilities", "spawnprotection.enabled"))
            {
                int startingX = ColonyAPI.Helpers.ServerVariableParser.GetVariableAsInt("Terrain.StartingX");
                int startingZ = ColonyAPI.Helpers.ServerVariableParser.GetVariableAsInt("Terrain.StartingZ");

                int distancex, distancez = 0;

                int playerX = (int)Pipliz.Math.RoundToInt(d.voxelHit.x);
                int playerZ = (int)Pipliz.Math.RoundToInt(d.voxelHit.z);

                distancex = System.Math.Abs(playerX - startingX);
                distancez = System.Math.Abs(playerZ - startingZ);

                int SpawnProtectionDistance = ColonyAPI.Managers.ConfigManager.getConfigInt("ColonyPlusPlus-Utilities", "spawnprotection.radius");

                //Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), String.Format("Distance from spawn: X {0}, Z {1}. Protection Radius: {2}", distancex, distancez, SpawnProtectionDistance));



                if (distancex > SpawnProtectionDistance || distancez > SpawnProtectionDistance)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }

        }

        private static bool allowBlockPlaceChunkOwnership(ModLoader.OnTryChangeBlockUserData d)
        {
            if (d.requestedBy.ID.steamID.m_SteamID == 0)
            {
                return true;
            }

            string ChunkID = ColonyAPI.Managers.WorldManager.XZPositionToString(d.voxelHit.ToChunk());
            if (Managers.WorldManager.ChunkDataList.ContainsKey(ChunkID))
            {
                Data.ChunkData cd = Managers.WorldManager.ChunkDataList[ChunkID];
                NetworkID id = cd.getOwner();
                if (cd.hasOwner())
                {
                    if (id == d.requestedBy.ID)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    //Utilities.WriteLog("Enforce: " + ConfigManager.getConfigBoolean("chunks.enforce"));
                    if (ColonyAPI.Managers.ConfigManager.getConfigBoolean("ColonyPlusPlus-Utilities", "chunks.enforce") == true)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
            }
            else
            {
                //Utilities.WriteLog("Enforce: " + ConfigManager.getConfigBoolean("chunks.enforce"));
                if (ColonyAPI.Managers.ConfigManager.getConfigBoolean("ColonyPlusPlus-Utilities", "chunks.enforce") == true)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static void SetupSpawn()
        {
            Vector3Int pos = new Vector3Int();
            pos.x = ColonyAPI.Helpers.ServerVariableParser.GetVariableAsInt("Terrain.StartingX");
            pos.z = ColonyAPI.Helpers.ServerVariableParser.GetVariableAsInt("Terrain.StartingZ");
            Vector3Int p = pos.ToChunk();
            int SpawnProtectionDistance = ColonyAPI.Managers.ConfigManager.getConfigInt("ColonyPlusPlus-Utilities", "spawnprotection.radius");
            for (int x = p.x - SpawnProtectionDistance; x < p.x + SpawnProtectionDistance; x++)
            {
                for (int z = p.z - SpawnProtectionDistance; z < p.z + SpawnProtectionDistance; z++)
                {

                    claimChunk(new Vector3Int(x * 16, 0, z * 16), new NetworkID(NetworkID.IDType.Server), true);

                }
            }
        }
    }
}