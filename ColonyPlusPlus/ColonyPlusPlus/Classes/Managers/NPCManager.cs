using Pipliz.JSON;
using Steamworks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class NPCManager
    {

        private static Dictionary<int, Data.NPCData> NPCDataList = new Dictionary<int, Data.NPCData>();

        public static void initialise()
        {
            loadNPCData();
        }

        public static Data.NPCData getNPCData(int id, Players.Player owner)
        {
            if (NPCDataList.ContainsKey(id)) {
                return NPCDataList[id];
            } else
            {
                Data.NPCData d = new Data.NPCData(owner);
                NPCDataList.Add(id, d);
                return d;
            }
        }

        public static void updateNPCData(int id, Data.NPCData d)
        {
            NPCDataList[id] = d;
        }

        public static void removeNPCData(int id)
        {
            if(NPCDataList.ContainsKey(id))
            {
                NPCDataList.Remove(id);
            }
        }

        public static void saveNPCData()
        {
            try
            {
                string jSONPath = GetJSONPath();
                Utilities.MakeDirectoriesIfNeeded(jSONPath);
                if (NPCDataList.Count == 0)
                {
                    File.Delete(jSONPath);
                }
                else
                {

                    // make a JSON node
                    JSONNode rootnode = new JSONNode(NodeType.Array);

                    // then go through stuff
                    foreach (int npcID in NPCDataList.Keys)
                    {
                        Data.NPCData npcData = NPCDataList[npcID];

                        // build a child node
                        JSONNode child = new JSONNode(NodeType.Object);

                        // Create the JSON
                        child.SetAs("id", npcID);
                        child.SetAs("owner", npcData.owner.ID.steamID);
                        child.SetAs("xpdata", npcData.XPData.toJSON());

                        rootnode.AddToArray(child);
                    }

                    Pipliz.JSON.JSON.Serialize(jSONPath, rootnode);

                }
            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Exception in saving all NPC Data:" + exception2.Message);
            }
        }

        public static void loadNPCData()
        {
            try
            {

                JSONNode array;
                if (Pipliz.JSON.JSON.Deserialize(GetJSONPath(), out array, false))
                {

                    if (array != null)
                    {
                        foreach (JSONNode node in array.LoopArray())
                        {
                            try
                            {
                               
                                int npcID = node["id"].GetAs<int>();
                                Players.Player owner = Players.GetPlayer(new NetworkID(new CSteamID(node["owner"].GetAs<ulong>())));

                                if (!NPCDataList.ContainsKey(npcID))
                                {
                                    // doesn't exist, add it!
                                    Data.NPCData npcData = new Data.NPCData(owner);
                                    JSONNode xpdata = node["xpdata"].GetAs<JSONNode>();

                                    if (xpdata.ChildCount > 0)
                                    {
                                        foreach (KeyValuePair<string, JSONNode> current in xpdata.LoopObject())
                                        {
                                            npcData.XPData.setXP(current.Key, current.Value.GetAs<ushort>());
                                        }
                                    }

                                }



                            }
                            catch (Exception exception)
                            {
                                Utilities.WriteLog("Exception loading NPC data;" + exception.Message);
                            }
                        }

                        Utilities.WriteLog("Loaded NPCData");
                    }
                    else
                    {
                        Utilities.WriteLog("Loading Crop Saves Returned 0 results");
                    }
                }
                else
                {
                    Utilities.WriteLog("Found no NPC Data (read error?)");
                }

            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Exception in saving all UpdatableBlocks:" + exception2.Message);
            }
        }

        private static string GetJSONPath()
        {
            return "gamedata/savegames/" + ServerManager.WorldName + "/cppnpcxp.json";
        }

    }

}
