using Pipliz.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes.Managers
{
    public static class CropManager
    {

        // a dictionary to hold the stage progressions of any given crops
        private static Dictionary<string, string> StageProgressions = new Dictionary<string, string>();

        // a list of crops in the world
        private static List<classes.Data.CropData> CropTracker = new List<Data.CropData>();

        // keep isntances of all the classes
        public static Dictionary<string, GrowableType> CropTypes = new Dictionary<string, GrowableType>();

        private static bool cropsLoaded = false;
              

        // Register crops
        public static void register()
        {
            classes.Utilities.WriteLog("Starting To Register Crops");

            types.Crops.CarrotStage1 CarrotStage1 = new types.Crops.CarrotStage1("carrotstage1");
            types.Crops.CarrotStage2 CarrotStage2 = new types.Crops.CarrotStage2("carrotstage2");
            types.Crops.CarrotStage3 CarrotStage3 = new types.Crops.CarrotStage3("carrotstage3");

            types.Crops.LettuceStage1 LettuceStage1 = new types.Crops.LettuceStage1("lettucestage1");
            types.Crops.LettuceStage2 LettuceStage2 = new types.Crops.LettuceStage2("lettucestage2");
            types.Crops.LettuceStage3 LettuceStage3 = new types.Crops.LettuceStage3("lettucestage3");


            types.Crops.PotatoStage1 PotatoStage1 = new types.Crops.PotatoStage1("potatostage1");
            types.Crops.PotatoStage2 PotatoStage2 = new types.Crops.PotatoStage2("potatostage2");
            types.Crops.PotatoStage3 PotatoStage3 = new types.Crops.PotatoStage3("potatostage3");

            types.Crops.OnionStage1 OnionStage1 = new types.Crops.OnionStage1("onionstage1");
            types.Crops.OnionStage2 OnionStage2 = new types.Crops.OnionStage2("onionstage2");
            types.Crops.OnionStage3 OnionStage3 = new types.Crops.OnionStage3("onionstage3");

            classes.Utilities.WriteLog("Ending Crop Registration");
        }

        // Run this every 500ms
        public static void doCropUpdates()
        {
            // Do we have crops in the world?
            if(CropTracker.Count > 0)
            {

                // a list of blocks to update
                List<classes.Data.CropData> updateList = new List<Data.CropData>();

                // a list of tracked crops to stop tracking (ie: where the crop is broken/finishes growing)
                List<classes.Data.CropData> CropTrackerToRemove = new List<Data.CropData>();

                // Go through each of the tracked crops
                foreach (classes.Data.CropData c in CropTracker)
                {
                    // update the amount of accumulated growth, as well as updating the last time the AG was updated
                    c.growthAccumulated = AccumulateGrowth(c,c.classInstance);
                    c.lastUpdateTimecycleHours = TimeCycle.TotalTime;
                    
                    // If the crop is fully grown
                    if (c.growthAccumulated > c.classInstance.maxGrowth)
                    {
                        // update the crop!

                        // Make sure the crop CAN be upgraded
                        if(hasProgression(c.classInstance.TypeName))
                        {
                            // set it as pending to update
                            updateList.Add(c);

                        } else
                        {
                            // if there's no way to update it then queue it for deletion
                            CropTrackerToRemove.Add(c);
                        }
                    }
                }

                // Loop through everything pending to update
                foreach (classes.Data.CropData c in updateList)
                {

                    // Get the next type
                    string newBlock = getNextStage(c.classInstance.TypeName);

                    // Update the block
                    updateBlock(c.location, newBlock);

                    // update the class relation in this struct (TODO: remove this in favour of type ushort)
                    CropTypes.TryGetValue(newBlock, out c.classInstance);

                    // Check again if the newblock has progression, if not, stop tracking this block
                    if(hasProgression(newBlock) == false)
                    {
                        // remove the block tracking
                        CropTrackerToRemove.Add(c);
                    }
                }


                // Do we have have things to stop tracking?
                if (CropTrackerToRemove.Count > 0)
                {
                    // Loop through everything we've said to stop tracking
                    foreach (classes.Data.CropData c in CropTrackerToRemove)
                    {
                        // Remove it from the tracker
                        CropTracker.Remove(c);
                    }
                }
            }
        }

        // Track a crop
        public static void trackCrop(Pipliz.Vector3Int location, GrowableType classInstance)
        {
            // Create a CropData struct to hold the data for this crop in this specific location
            Data.CropData cd = new Data.CropData(location, classInstance);

            // Add it to the tracking list
            CropTracker.Add(cd);

            SaveCropTracker();
        }

        public static void loadTrackCrop(Pipliz.Vector3Int location, GrowableType classInstance, float growth, double time)
        {
            // Create a CropData struct to hold the data for this crop in this specific location
            Data.CropData cd = new Data.CropData(location, classInstance, growth, time);

            // Add it to the tracking list
            CropTracker.Add(cd);
        }

        // Stop tracking a crop
        public static void untrackCrop(Pipliz.Vector3Int location, GrowableType classInstance)
        {
            // Create a list of things to stop tracking
            List<classes.Data.CropData> CropTrackerToRemove = new List<Data.CropData>();

            // Is it in our croptracker list?
            foreach (Data.CropData c in CropTracker)
            {
                // ah yes, it is, mark it for removal
                if(c.location == location)
                {
                    // ...
                    CropTrackerToRemove.Add(c);
                }
            }

            // If we have things to remove (we should only ever have 1!)
            if (CropTrackerToRemove.Count > 0)
            {
                // Loop through them
                foreach (classes.Data.CropData c in CropTrackerToRemove)
                {
                    // Remove it from the tracker
                    CropTracker.Remove(c);
                }
            }

            SaveCropTracker();
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

        // Add calculated growth to a crop
        public static float AccumulateGrowth(classes.Data.CropData cropdata, GrowableType type)
        {
            // get the current daytime
            double totalTime = TimeCycle.TotalTime;

            // Make sure it is both currently day, and is currently daytime
            if ((cropdata.lastUpdateTimecycleHours >= 0.0) && TimeCycle.IsDay)
            {
                // calculate a time
                float num2 = (float)(totalTime - cropdata.lastUpdateTimecycleHours);
                if (num2 < TimeCycle.DayLength)
                {
                    // add it to the time, multiplied by a random float between min and max multiplier taken from the item class
                    cropdata.growthAccumulated += num2 * Pipliz.Random.NextFloat(type.growthMultiplierMin, type.growthMultiplierMax);
                }
            }

            // return the accumulated growth
            return cropdata.growthAccumulated;
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
                    foreach(classes.Data.CropData c in CropTracker)
                    {
                        // build a child node
                        JSONNode child = new JSONNode(NodeType.Object);
                 
                        // Create the JSON
                        child.SetAs("location", (JSONNode)c.location);
                        child.SetAs("typename", c.classInstance.TypeName);
                        child.SetAs("growthAccumulated", c.growthAccumulated);
                        child.SetAs("lastUpdateTimecycleHours", c.lastUpdateTimecycleHours);

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
                                string typename = node["typename"].GetAs<string>();
                                GrowableType instanceclass;
                                CropTypes.TryGetValue(typename, out instanceclass);

                                float growthAccumulated = node["growthAccumulated"].GetAs<float>();
                                double lastUpdateTimecycleHours = node["lastUpdateTimecycleHours"].GetAs<double>();

                                loadTrackCrop(location, instanceclass, growthAccumulated, lastUpdateTimecycleHours);

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


