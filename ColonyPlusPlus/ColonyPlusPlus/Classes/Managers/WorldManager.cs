using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Data;
using Pipliz;
using System.IO;
using Pipliz.JSON;
using Steamworks;
using UnityEngine;
using Permissions;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class WorldManager
    {
        public static Dictionary<string, ChunkData> ChunkDataList = new Dictionary<string, ChunkData>();

        private static bool worldManagerLoaded = false;


        public static string positionToString(Vector3Int position)
        {
            return position.x + "," + position.y + "," + position.z;
        }

        public static bool claimChunk(Vector3Int position, NetworkID playerid)
        {
            Vector3Int p = position.ToChunk();
            string chunkname = positionToString(p);
            if (ChunkDataList.ContainsKey(chunkname))
            {
                ChunkData c = ChunkDataList[chunkname];

                bool result = c.setOwner(playerid);
                SaveJSON();

                return result;
            }
            else
            {
                ChunkData c = new ChunkData(p, true, playerid);
              
                ChunkDataList.Add(chunkname, c);
                SaveJSON();

                return true;
            }
        }

        public static bool unclaimChunk(Vector3Int position, NetworkID playerid, bool force = false)
        {
            Vector3Int p = position.ToChunk();
            string chunkname = positionToString(p);

            if (ChunkDataList.ContainsKey(chunkname))
            {
                ChunkData c = ChunkDataList[chunkname];
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

            foreach(string k in ChunkDataList.Keys)
            {
                if(ChunkDataList[k].getOwner() == p)
                {
                    owned += 1;
                }
            }

            return owned;
        }

        public static Vector3Int positionToVector3Int(Vector3 pos)
        {
            int playerX = Pipliz.Math.RoundToInt(pos.x);
            int playerY = Pipliz.Math.RoundToInt(pos.y);
            int playerZ = Pipliz.Math.RoundToInt(pos.z);

            Vector3Int position = new Vector3Int(playerX, playerY, playerZ);

            return position;
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
                Utilities.MakeDirectoriesIfNeeded(jSONPath);
                if (ChunkDataList.Count == 0)
                {
                    File.Delete(jSONPath);
                }
                else
                {

                    // make a JSON node
                    JSONNode rootnode = new JSONNode(NodeType.Array);

                    // then go through stuff
                    foreach (Classes.Data.ChunkData c in ChunkDataList.Values)
                    {
                        // build a child node
                        JSONNode child = new JSONNode(NodeType.Object);

                        // Create the JSON
                        child.SetAs("location", (JSONNode)c.location);
                        child.SetAs("chunkID", positionToString(c.location));
                        child.SetAs("owned", c.hasOwner());
                        child.SetAs("playerID", c.getOwner().steamID.m_SteamID);

                        rootnode.AddToArray(child);
                    }

                    Pipliz.JSON.JSON.Serialize(jSONPath, rootnode);

                }
            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Exception in saving all Owned Chunks:" + exception2.Message);
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

                                ChunkData instanceclass;

                                bool owned = node["owned"].GetAs<bool>();
                                ulong playerID = node["playerID"].GetAs<ulong>();

                                if(playerID > 0)
                                {
                                    instanceclass = new ChunkData(location, owned, new NetworkID(new CSteamID(playerID)));

                                    ChunkDataList.Add(chunkID, instanceclass);

                                    chunksloaded += 1;
                                }
                                

                            }
                            catch (Exception exception)
                            {
                                Utilities.WriteLog("Exception loading a wheat block;" + exception.Message);
                            }
                        }

                        Utilities.WriteLog("Loaded Chunk Data (" + chunksloaded + " chunks)");
                        
                    }
                    else
                    {
                        Utilities.WriteLog("Loading Chunk Data Returned 0 results");
                    }
                }
                else
                {
                    Utilities.WriteLog("Found no chunk data (read error?)");
                }

            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Exception in loading all Chunk Data:" + exception2.Message);
            }

            worldManagerLoaded = true;
        }


        public static bool AllowPlaceBlock(ModLoader.OnTryChangeBlockUserData d)
        {
            // Check permissions
            if(PermissionsManager.CheckAndWarnPermission(Players.GetPlayer(d.requestedBy.ID), "world.build"))
            {
                Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You have build permissions");

                // first check if near spawn
                if (allowBlockFarEnoughFromSpawn(d))
                {
                    Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You are far enough from spawn");
                    // what about chunk ownership
                    if (allowBlockPlaceChunkOwnership(d))
                    {
                        Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You own the chunk");
                        return true;
                    } else
                    {
                        Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You dno't own the chunk");
                        return false;
                    }
                }
                else
                {
                    if(PermissionsManager.CheckAndWarnPermission(Players.GetPlayer(d.requestedBy.ID), "world.buildspawn"))
                    {
                        return true;
                    }
                    else
                    {
                        Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You aren't far enough from spawn");
                        return false;
                    }
                }
            }
            else
            {
                Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), "You don't have build permissions");
                return false;
            }






            
        }

        private static bool allowBlockFarEnoughFromSpawn(ModLoader.OnTryChangeBlockUserData d)
        {
            if(Classes.Managers.ConfigManager.getConfigBoolean("SpawnProtection"))
            {
                int startingX = Classes.Managers.ServerVariablesManager.GetVariableAsInt("Terrain.StartingX");
                int startingZ = Classes.Managers.ServerVariablesManager.GetVariableAsInt("Terrain.StartingZ");

                int distancex, distancez = 0;

                
                int playerX = (int)Pipliz.Math.RoundToInt(d.position.x);
                int playerZ = (int)Pipliz.Math.RoundToInt(d.position.z);
                
                distancex = System.Math.Abs(playerX - startingX);
                distancez = System.Math.Abs(playerZ - startingZ);


                Helpers.Chat.send(Players.GetPlayer(d.requestedBy.ID), String.Format("Distance from spawn: X {0}, Z {1}", distancex, distancez));

                int SpawnProtectionDistance = Classes.Managers.ConfigManager.getConfigInt("SpawnProtectionRadius");

                if (distancex > SpawnProtectionDistance || distancez > SpawnProtectionDistance)
                {
                    return true;
                } else
                {
                    return false;
                }
            } else
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

            string ChunkID = Classes.Managers.WorldManager.positionToString(d.position.ToChunk());
            if (Classes.Managers.WorldManager.ChunkDataList.ContainsKey(ChunkID))
            {
                Classes.Data.ChunkData cd = Classes.Managers.WorldManager.ChunkDataList[ChunkID];
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
                    return true;

                }
            }
            return true;
        }
    }
}
