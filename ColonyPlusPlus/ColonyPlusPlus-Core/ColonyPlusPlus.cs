using static Players;
using System;

namespace ColonyPlusPlusCore
{
    [ModLoader.ModManager]
    public class ColonyPlusPlus
    {
        private static long nextMillisecondUpdate = 0;
        private static long nextMillisecondUpdateLong = 0;
        public static long nextMillisecondUpdateRotator = 0;
        private static long millisecondDelta = 500;
        public static long millisecondDeltaRotator = 0;

        private static bool ColonyLimitEnabled = false;
        private static int ColonyLimit = 0;
        private static int plyID = 0;
        public static Version modVersion = new Version(0, 2, 0, 5);


        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "colonypluspluscore.AfterStartup")]
        [ModLoader.ModCallbackDependsOn("colonyapi.initialise")]
        public static void AfterStartup()
        {

            ColonyAPI.Managers.VersionManager.addVersionURL("ColonyPlusPlus-Core", "https://raw.githubusercontent.com/ColonyPlusPlus/ColonyPlusPlus/master/docs/currentversion_core.md");
            ColonyAPI.Managers.VersionManager.runVersionCheck("ColonyPlusPlus-Core", modVersion);

            // Initialise configuration
            ColonyAPI.Managers.ConfigManager.registerConfig("ColonyPlusPlus-Core");
           
            ColonyLimitEnabled = ColonyAPI.Managers.ConfigManager.getConfigBoolean("ColonyPlusPlus-Core", "colony.enabled");
            if(ColonyLimitEnabled)
            {
                ColonyLimit = ColonyAPI.Managers.ConfigManager.getConfigInt("ColonyPlusPlus-Core", "colony.limit");
            }


            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Core", "Loaded ColonyPlusPlus Core v" + modVersion.ToString(), ColonyAPI.Helpers.Chat.ChatColour.yellow, ColonyAPI.Helpers.Chat.ChatStyle.normal);

        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnectedLate, "colonypluspluscore.OnPlayerConnectedLate")]
        public static void OnPlayerConnectedLate(Player p)
        {
            if (p.ID.steamID.m_SteamID == 0)
            {
                ColonyAPI.Helpers.Chat.sendSilent(p, ColonyAPI.Managers.VersionManager.SinglePlayerrunVersionCheck("ColonyPlusPlus-Core", modVersion), ColonyAPI.Helpers.Chat.ChatColour.red);
            }
            else
            {
                ColonyAPI.Helpers.Chat.sendSilent(p, "The server is using ColonyPlusPlus v" + modVersion.ToString());
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes, "colonypluspluscore.materials")]
        [ModLoader.ModCallbackProvidesFor("colonyapi.registerMaterials")]
        public static void RegisterMaterials()
        {
            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus", "Starting Material Registration");

            // Register Materials
            Managers.MaterialManager.initialiseMaterials();

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus", "Ending Material Registration");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes, "colonypluspluscore.AfterAddingBaseTypes")]
        [ModLoader.ModCallbackProvidesFor("colonyapi.discoverTypes")]
        public static void RegisterCrops()
        {
        
            // Register crop Types
            Managers.CropManager.register();

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus", "Registered Crops");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesServer, "colonypluspluscore.AfterItemTypesServer")]
        public static void AfterItemTypesServer()
        {
            // Register Tracked Block Types (Wheat?)
            Managers.TypeManager.registerTrackedTypes();
            
            // Regsiter types with actions
            Managers.TypeManager.registerActionableTypes();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad, "colonypluspluscore.AfterWorldLoad")]
        public static void AfterWorldLoad()
        {
            Managers.CropManager.LoadCropTracker();
       
            Managers.NPCManager.initialise();

            //Classes.BlockJobs.BlockJobManagerTracker.AfterWorldLoad();
        }

        // things to do every tick (or itnerval)
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnUpdate, "colonypluspluscore.OnUpdate")]
        public static void OnUpdate()
        {
            if(Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdate)
            {
                // update any crops
                Managers.CropManager.doCropUpdates();
               
                // set the next update time!
                nextMillisecondUpdate = Pipliz.Time.MillisecondsSinceStart + millisecondDelta;
            }

            // Run once a minute
            if (Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdateLong)
            {

                // save out crop progress to file
                Managers.CropManager.SaveCropTrackerInterval();
                              
                // long term update time
                nextMillisecondUpdateLong = Pipliz.Time.MillisecondsSinceStart +  60000;
            }

        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuitEarly, "colonypluspluscore.OnQuitEarly")]
        public static void OnQuitEarly()
        {
            Managers.CropManager.SaveCropTracker();
           

            Managers.NPCManager.saveNPCData();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuit, "colonypluspluscore.OnQuit")]
        public static void OnQuit()
        {
            //Classes.BlockJobs.BlockJobManagerTracker.Save();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterDefiningNPCTypes, "colonypluspluscore.AfterDefiningNPCTypes")]
        [ModLoader.ModCallbackProvidesForAttribute("pipliz.apiprovider.jobs.resolvetypes")]
        public static void AfterDefiningNPCTypes()
        {
            Managers.NPCManager.registerAllJobs();
        
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "colonypluspluscore.AfterItemTypesDefined")]
        [ModLoader.ModCallbackDependsOn("pipliz.blocknpcs.loadrecipes")]
        [ModLoader.ModCallbackProvidesFor("pipliz.apiprovider.registerrecipes")]
        public static void AfterItemTypesDefined()
        {
            Managers.RecipeManager.AddBaseRecipes();
            Managers.RecipeManager.ProcessRecipes();
        }
    }
}