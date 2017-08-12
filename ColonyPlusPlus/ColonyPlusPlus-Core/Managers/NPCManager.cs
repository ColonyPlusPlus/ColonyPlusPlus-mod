using Pipliz.JSON;
using Steamworks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Classes.Managers
{
    public static class NPCManager
    {

        private static Dictionary<int, Data.NPCData> NPCDataList = new Dictionary<int, Data.NPCData>();
        private static JSONNode NPCNameList = new JSONNode(NodeType.Array);

        public static int baseXP = 10;
        public static int maxLevel = 25;
        public static float XPMultiplier = 2;
        public static float EfficiencyPerLevel = 0.02f;

        public static void initialise()
        {
            loadNPCData();
            baseXP = ColonyAPI.Managers.ConfigManager.getConfigInt("ColonyPlusPlusCore", "jobs.baseXP");
            maxLevel = ColonyAPI.Managers.ConfigManager.getConfigInt("ColonyPlusPlusCore", "jobs.maxLevel");
            XPMultiplier = ColonyAPI.Managers.ConfigManager.getConfigFloat("ColonyPlusPlusCore", "jobs.xpMultiplier");
            EfficiencyPerLevel = ColonyAPI.Managers.ConfigManager.getConfigFloat("ColonyPlusPlusCore", "jobs.efficiencyPerLevel");

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", String.Format("NPC Config: baseXP: {0}, maxLevel: {1}, xpMultiplier: {2}, efficiencyPerLevel: {3}",baseXP, maxLevel, XPMultiplier, EfficiencyPerLevel));

            JSONNode array;
            if (Pipliz.JSON.JSON.Deserialize("gamedata/mods/colonyplusplus/npcnames.json", out array, false))
            {
                NPCNameList = array;
                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Loaded NPC Names List");
            } else
            {
                JSONNode j = new JSONNode(NodeType.Array);
                j.SetAs<string>("Dave");
                NPCNameList.AddToArray(j);

                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Failed to load NPC Names List - assumed Dave");
            }
        }

        public static void registerAllJobs()
        {
            removeBaseJobs();

            //REIMPLEMENTED BASE JOBS
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.BaseJobs.Grinder>("grindstone");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.BaseJobs.Minter>("mint");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.BaseJobs.Merchant>("shop");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.BaseJobs.Tailor>("tailorshop");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.BaseJobs.Technologist>("technologisttable");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.BaseJobs.Crafter>("workbench");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.BaseJobs.Smelter>("furnace");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.BaseJobs.Baker>("oven");

            // CUSTOM JOBS
            //CraftingJobs
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Blacksmith>("anvil");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Carpenter>("sawmill");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.ChickenPluckerJob>("chickencoop");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.StoneMason>("masontable");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.WellOperator>("well");
            //FueledCraftingJobs
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.FueledCraftingJob.PotteryJob>("potterytable");
            //DefenseJobs
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.Defense.BaseQuiver>("quiver");

        }

        public static void removeBaseJobs()
        {
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("grindstone");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("mint");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("shop");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("tailorshop");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("technologisttable");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("workbench");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("furnace");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("oven");
            Pipliz.APIProvider.Jobs.BlockJobManagerTracker.ClearType("quiver");
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

        public static bool npcExists(int i)
        {
            if(NPCDataList.ContainsKey(i))
            {
                return true; 
            } else
            {
                return false;
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
                ColonyAPI.Helpers.Utilities.MakeDirectoriesIfNeeded(jSONPath);
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
                        child.SetAs("name", npcData.name);

                        rootnode.AddToArray(child);
                    }

                    Pipliz.JSON.JSON.Serialize(jSONPath, rootnode);

                }
            }
            catch (Exception exception2)
            {
                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Exception in saving all NPC Data:" + exception2.Message);
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

                                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Loading NPC:" + npcID);
                                ulong ownerU = node["owner"].GetAs<ulong>();
                                Players.Player owner;

                                if (ownerU == 0)
                                {
                                    owner = Players.GetPlayer(new NetworkID(NetworkID.IDType.LocalHost));
                                } else
                                {
                                    owner = Players.GetPlayer(new NetworkID(new CSteamID(ownerU)));
                                }


                                

                                if (!NPCDataList.ContainsKey(npcID))
                                {
                                    // doesn't exist, add it!
                                    Data.NPCData npcData = new Data.NPCData(owner);

                                    ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", String.Format("ID: {0}, ownerU: {1}, ", npcID, ownerU));
                                    JSONNode xpdata = node["xpdata"].GetAs<JSONNode>();

                                    if (xpdata.ChildCount > 0)
                                    {
                                        foreach (KeyValuePair<string, JSONNode> current in xpdata.LoopObject())
                                        {
                                            npcData.XPData.setXP(current.Key, current.Value.GetAs<ushort>());
                                            //Utilities.WriteLog("Added XP: " + current.Key + " value: " + current.Value.GetAs<ushort>());
                                        }
                                    }
                                    npcData.XPData.recalculateAllLevels();

                                    string npcName = node["name"].GetAs<string>();
                                    npcData.name = npcName;

                                    NPCDataList.Add(npcID, npcData);

                                }



                            }
                            catch (Exception exception)
                            {
                                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Exception loading NPC data;" + exception.Message);
                            }
                        }

                        ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Loaded NPCData");
                    }
                    else
                    {
                        ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Loading NPC data returned 0 results");
                    }
                }
                else
                {
                    ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Found no NPC Data (read error?)");
                }

            }
            catch (Exception exception2)
            {
                ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlusCore", "Exception in loading NPC data:" + exception2.Message);
            }
        }

        private static string GetJSONPath()
        {
            return "gamedata/savegames/" + ServerManager.WorldName + "/cppnpcxp.json";
        }

        public static string getRandomName()
        {
            string name = "";

            int maxN = NPCNameList.ChildCount;

            int nameIndex = 0;

            if (maxN > 0)
            {
                nameIndex = Pipliz.Random.Next(0, maxN - 1);
            } else {
                return "Dave";
            }
            name = NPCNameList[nameIndex].GetAs<string>();

            return name;
        }

    }

}
