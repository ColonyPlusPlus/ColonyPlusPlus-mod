using Pipliz;
using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class CropManager
    {

        // a dictionary to hold the stage progressions of any given crops
        private static Dictionary<string, string> StageProgressions = new Dictionary<string, string>();

        // a list of crops in the world
        private static Dictionary<string, Vector3Int> CropTracker = new Dictionary<string, Vector3Int>();
        private static Dictionary<long, List<string>> CropUpdateHolder = new Dictionary<long, List<string>>();

        // keep isntances of all the classes
        public static Dictionary<string, GrowableType> CropTypes = new Dictionary<string, GrowableType>();

        private static bool cropsLoaded = false;
       
        // Register crops
        public static void register()
        {
            Classes.Utilities.WriteLog("Starting To Register Crops");

            Types.Crops.CarrotStage1 CarrotStage1 = new Types.Crops.CarrotStage1("carrotstage1");
            Types.Crops.CarrotStage2 CarrotStage2 = new Types.Crops.CarrotStage2("carrotstage2");
            Types.Crops.CarrotStage3 CarrotStage3 = new Types.Crops.CarrotStage3("carrotstage3");

            Types.Crops.LettuceStage1 LettuceStage1 = new Types.Crops.LettuceStage1("lettucestage1");
            Types.Crops.LettuceStage2 LettuceStage2 = new Types.Crops.LettuceStage2("lettucestage2");
            Types.Crops.LettuceStage3 LettuceStage3 = new Types.Crops.LettuceStage3("lettucestage3");


            Types.Crops.PotatoStage1 PotatoStage1 = new Types.Crops.PotatoStage1("potatostage1");
            Types.Crops.PotatoStage2 PotatoStage2 = new Types.Crops.PotatoStage2("potatostage2");
            Types.Crops.PotatoStage3 PotatoStage3 = new Types.Crops.PotatoStage3("potatostage3");

            Types.Crops.OnionStage1 OnionStage1 = new Types.Crops.OnionStage1("onionstage1");
            Types.Crops.OnionStage2 OnionStage2 = new Types.Crops.OnionStage2("onionstage2");
            Types.Crops.OnionStage3 OnionStage3 = new Types.Crops.OnionStage3("onionstage3");

            Classes.Utilities.WriteLog("Ending Crop Registration");
        }

        // Run this every 500ms
        public static void doCropUpdates()
        {
            long updateStartTime = Pipliz.Time.MillisecondsSinceStart;

            Pipliz.Chatting.Chat.SendToAll("Current time:" + updateStartTime, Pipliz.Chatting.ChatSenderType.Server);

            // Do we have crops in the world?
            if(CropUpdateHolder.Count > 0)
            {
                // A dictionary to store a list of keys
                Dictionary<long, List<string>> CropsToUpdate = CropUpdateHolder.Where(c => c.Key < updateStartTime).ToDictionary(k => k.Key, k => k.Value); 

                // we have crops to update!
                if(CropsToUpdate.Count > 0)
                {
                    // loop through each expired time
                    foreach(long time in CropsToUpdate.Keys)
                    {
                        // does the child lsit have a nice list of crops to update at this time?
                        if(CropsToUpdate[time].Count > 0)
                        {
                            foreach(string cropLocString in CropsToUpdate[time])
                            {
                                // get the instance of the crop tracker and check it exists!
                                if(!CropTracker.ContainsKey(cropLocString))
                                {
                                    // it doesn't exist, so just ignore it
                                    continue;
                                }

                                ushort currentBlockID;
                                World.TryGetTypeAt(CropTracker[cropLocString], out currentBlockID);

                                string currentBlockName = ItemTypes.IndexLookup.GetName(currentBlockID);

                                // check if it can be updated
                                if (hasProgression(currentBlockName))
                                {
                                    Utilities.WriteLog("Can update " + currentBlockName);
                                    // get the new stage
                                    string newBlockName = getNextStage(currentBlockName);

                                    // update the block
                                    updateBlock(CropTracker[cropLocString], newBlockName);

                                    // check this isn't the last stage
                                    if (hasProgression(newBlockName))
                                    {

                                        Utilities.WriteLog("Is not last stage!" + newBlockName);
                                        // update the next update time

                                        // get a new classinstance to calculate the proper growth time
                                        GrowableType g = CropTypes[newBlockName];
                                        long nextUpdate = (long)(Pipliz.Time.MillisecondsSinceStart + g.maxGrowth * Pipliz.Random.NextFloat(g.growthMultiplierMin, g.growthMultiplierMax) * 60000);

                                        // add it to the update list
                                        if(CropUpdateHolder.ContainsKey(nextUpdate))
                                        {
                                            // other crops are set to update at this time too, so add this to the list
                                            CropUpdateHolder[nextUpdate].Add(cropLocString);
                                        } else
                                        {
                                            // no crops are currently setup to update at this time, make a new list
                                            CropUpdateHolder.Add(nextUpdate, new List<string>() { cropLocString });
                                        }

                                    } else
                                    {
                                        // this is the last stage, remove it from the croptracker too!
                                        CropTracker.Remove(cropLocString);
                                    }

                                } else
                                {
                                    // this should have been removed but wasn't... remove it now I guess...
                                    CropTracker.Remove(cropLocString);
                                }
                            }
                           
                        }

                        // remove the crop update holder, it'll be re-added anyway for the enxt update
                        CropUpdateHolder.Remove(time);
                        Utilities.WriteLog("Now tracking:" + CropTracker.Count + " crops");
                    }

                    SaveCropTracker();
                }
            }

        }

        // when is the next update?
        public static long getNextUpdateTime(float maxGrowth, float growthMultiplierMin, float growthMultiplierMax)
        {
           return (long)(Pipliz.Time.MillisecondsSinceStart + maxGrowth * Pipliz.Random.NextFloat(growthMultiplierMin, growthMultiplierMax) * 60000);
        }

        // Track a crop
        public static void trackCrop(Pipliz.Vector3Int location, GrowableType classInstance, bool save = false)
        {
            long nextUpdate = (long)(Pipliz.Time.MillisecondsSinceStart + classInstance.maxGrowth * Pipliz.Random.NextFloat(classInstance.growthMultiplierMin, classInstance.growthMultiplierMax) * 60000);
            string cropLocString = Managers.WorldManager.positionToString(location);

            CropTracker.Add(cropLocString, location);
            Utilities.WriteLog("queued crop for update at: " + nextUpdate + "");

            Utilities.WriteLog("Now tracking:" + CropTracker.Count + " crops");

            // add it to the update list
            if (CropUpdateHolder.ContainsKey(nextUpdate))
            {
                // other crops are set to update at this time too, so add this to the list
                CropUpdateHolder[nextUpdate].Add(cropLocString);
            }
            else
            {
                // no crops are currently setup to update at this time, make a new list
                CropUpdateHolder.Add(nextUpdate, new List<string>() { cropLocString });
            }

            if(save == true)
            {
                SaveCropTracker();
            }
        }

        public static void loadTrackCrop(Pipliz.Vector3Int location, GrowableType classInstance)
        {
            trackCrop(location, classInstance);
            //SaveCropTracker();
        }

        // Stop tracking a crop
        public static void untrackCrop(Pipliz.Vector3Int location, GrowableType classInstance, bool save = false)
        {
            // check if it's being tracked, if so remove it
            string cropLocString = Managers.WorldManager.positionToString(location);

            if (CropTracker.ContainsKey(cropLocString))
            {
                CropTracker.Remove(cropLocString);
            }

            if (save == true)
            {
                SaveCropTracker();
            }
        }

        // Does this type have a next growth stage?
        public static bool hasProgression(string type)
        {
            // does our progression dictionary contain this type?
            if (StageProgressions.ContainsKey(type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Update a block
        public static void updateBlock(Pipliz.Vector3Int location, string newblocktype)
        {

            // Find the block ID
            ushort newBlockID = ItemTypes.IndexLookup.GetIndex(newblocktype);

            // Set the block, don't send a causedby ID
            ServerManager.TrySetBlock(location, newBlockID, NetworkID.Invalid);

        }

        // Add a crop stage
        public static void addCropStage(string initialStage, string nextStage)
        {
            // Add it
            StageProgressions.Add(initialStage, nextStage);
        }

        // Get the type which follows this stage
        public static string getNextStage(string type)
        {
            // make sure it actually contains the key
            if (StageProgressions.ContainsKey(type))
            {
                // get the returned type
                string returntype;
                StageProgressions.TryGetValue(type, out returntype);

                // return it
                return returntype;
            }
            else
            {
                return "";
            }
        }

       


        private static string GetJSONPath()
        {
            return "gamedata/savegames/" + ServerManager.WorldName + "/cppcrops.json";
        }


        // Saving the crop tracker
        public static void SaveCropTracker()
        {
            try
            {
                string jSONPath = GetJSONPath();
                Pipliz.Helpers.Helper.MakeDirectoriesIfNeeded(jSONPath);
                if (CropTracker.Count == 0)
                {
                    File.Delete(jSONPath);
                }
                else
                {
                    
                    // make a JSON node
                    JSONNode rootnode = new JSONNode(NodeType.Array);

                    // then go through stuff
                    foreach(string cLoc in CropTracker.Keys)
                    {
                        // build a child node
                        JSONNode child = new JSONNode(NodeType.Object);
                 
                        // Create the JSON
                        child.SetAs("location", (JSONNode)CropTracker[cLoc]);

                        ushort currentBlockID;
                        World.TryGetTypeAt(CropTracker[cLoc], out currentBlockID);

                        string currentBlockName = ItemTypes.IndexLookup.GetName(currentBlockID);
                        child.SetAs("typename", currentBlockName);

                        rootnode.AddToArray(child);
                    }

                    Pipliz.JSON.JSON.Serialize(jSONPath, rootnode);
                    
                }
            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Exception in saving all UpdatableBlocks:" + exception2.Message);
            }
        }

        public static void SaveCropTrackerInterval()
        {
            if (cropsLoaded == true)
            {
                SaveCropTracker();
                Utilities.WriteLog("Updated Crop Save [Interval]");
            }
        }

        public static void LoadCropTracker()
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
                                // recapture location
                                Pipliz.Vector3Int location = new Pipliz.Vector3Int();
                                location = (Pipliz.Vector3Int)node["location"];

                                // recapture instance class
                                string typename;
                                typename = node["typename"].GetAs<string>();
                                Utilities.WriteLog("Loaded crop of type: " + typename);
                               
                                if(CropTypes.ContainsKey(typename))
                                {
                                    loadTrackCrop(location, CropTypes[typename]);
                                }

                                

                            }
                            catch (Exception exception)
                            {
                                Utilities.WriteLog("Exception loading a wheat block;" + exception.Message);
                            }
                        }

                        Utilities.WriteLog("Loaded Crop Saves");
                        SaveCropTracker();
                    } else
                    {
                        Utilities.WriteLog("Loading Crop Saves Returned 0 results");
                    }
                } else
                {
                    Utilities.WriteLog("Found no crop saves (read error?)");
                }

            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Exception in saving all UpdatableBlocks:" + exception2.Message);
            }

            cropsLoaded = true;
        }

    }
}


