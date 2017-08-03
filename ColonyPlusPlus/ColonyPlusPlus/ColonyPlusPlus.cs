using Pipliz.Chatting;
using static Players;
using System;
using System.Collections.Generic;
using ColonyPlusPlus.Classes;

namespace ColonyPlusPlus
{
    [ModLoader.ModManager]
    public class ColonyPlusPlus
    {

        private static long nextMillisecondUpdate = 0;
        private static long nextMillisecondUpdateLong = 0;
        public static long nextMillisecondUpdateRotator = 0;
        private static long millisecondDelta = 500;
        public static long millisecondDeltaRotator = 0;
        private static bool CustomCrops = false;
        private static bool CustomJobs = false;

        public static Version modVersion = new Version(0, 2, 0);

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup)]
        public static void AfterStartup()
        {
            Pipliz.Log.Write("<b><color=yellow>Loaded ColonyPlusPlus v" + modVersion.ToString() + "</color></b>");
            Classes.Managers.VersionManager.runVersionCheck(modVersion);

            // Initialise configuration
            Classes.Managers.ConfigManager.initialise();
            Classes.Managers.RotatingMessageManager.initialise();
            Classes.Managers.ServerVariablesManager.init();

            CustomJobs = Classes.Managers.ConfigManager.getConfigBoolean("CustomJobs");
            CustomCrops = Classes.Managers.ConfigManager.getConfigBoolean("CustomCrops");

            // Initialize chat commands
            Classes.Managers.ChatCommandManager.Initialize();

           
            
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnectedLate)]
        public static void OnPlayerConnectedLate(Player p)
        {
            if(p.ID.steamID.m_SteamID == 0)
            {
                Classes.Helpers.Chat.send(p, Classes.Managers.VersionManager.SinglePlayerrunVersionCheck(modVersion), Classes.Helpers.Chat.ChatColour.red);
            }
            Chat.Send(p, Classes.Managers.ConfigManager.getConfigString("motd"));

           

            
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes)]
        public static void AfterAddingBaseTypes()
        {
            // Register Materials
            Classes.Managers.BaseGameMaterialManager.initialiseMaterials();
            Classes.Managers.MaterialManager.initialiseMaterials();

            // Register basegame Types
            Classes.Managers.BaseGameManager.registerBlocks();
            Classes.Managers.BaseGameManager.registerItems();

            // Register Types
            Classes.Managers.BlockManager.register();
            Classes.Managers.ItemManager.register();
            if(CustomCrops)
                Classes.Managers.CropManager.register();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesServer)]
        public static void AfterItemTypesServer()
        {
            // Register Tracked Block Types (Wheat?)
            if (CustomCrops)
                Classes.Managers.TypeManager.registerTrackedTypes();

            // Register Master Command
            ChatCommands.CommandManager.RegisterCommand(new Classes.Managers.MasterChatCommandManager());
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad)]
        public static void AfterWorldLoad()
        {
            Classes.Managers.RecipeManager.AddBaseRecipes();
            Classes.Managers.RecipeManager.BuildRecipeList();
            Classes.Managers.RecipeManager.ProcessRecipes();


            if (CustomCrops)
                Classes.Managers.CropManager.LoadCropTracker();
            Classes.Managers.WorldManager.LoadJSON();

            Classes.BlockJobs.BlockJobManagerTracker.AfterWorldLoad();
        }

        // things to do every tick (or itnerval)
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnUpdate)]
        public static void OnUpdate()
        {
            if(Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdate)
            {
                // do stuff

                // update any crops
                if (CustomCrops)
                    Classes.Managers.CropManager.doCropUpdates();

                // Do player update stuff
                Classes.Managers.PlayerManager.notifyNewChunkEntrances();

                // set the next update time!
                nextMillisecondUpdate = Pipliz.Time.MillisecondsSinceStart + millisecondDelta;
            }

            // Run once a minute
            if (Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdateLong)
            {

                // save out crop progress to file
                if (CustomCrops)
                    Classes.Managers.CropManager.SaveCropTrackerInterval();

                // long term update time
                nextMillisecondUpdateLong = Pipliz.Time.MillisecondsSinceStart +  60000;
            }

            // run the rotator
            Classes.Managers.RotatingMessageManager.doRun();

        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuitEarly)]
        public static void OnQuitEarly()
        {
            if (CustomCrops)
                Classes.Managers.CropManager.SaveCropTracker();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuit)]
        public static void OnQuit()
        {
            Classes.BlockJobs.BlockJobManagerTracker.Save();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterDefiningNPCTypes)]
        public static void AfterDefiningNPCTypes()
        {
            //Crafting Jobs!
            Classes.BlockJobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Implementations.GrinderJob>("grindstone");
            Classes.BlockJobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Implementations.MintJob>("mint");
            Classes.BlockJobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Implementations.ShopJob>("shop");
            Classes.BlockJobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Implementations.WorkBenchJob>("workbench");
            //Fueled Jobs!
            Classes.BlockJobs.BlockJobManagerTracker.Register<Classes.BlockJobs.FueledCraftingJob.Implementations.FurnaceJob>("furnace");
            Classes.BlockJobs.BlockJobManagerTracker.Register<Classes.BlockJobs.FueledCraftingJob.Implementations.OvenJob>("oven");
            //Odd Jobs?
            Classes.BlockJobs.BlockJobManagerTracker.Register<Classes.BlockJobs.Implementations.QuiverJob>("quiver");


            //Custom jobs!
            if (Classes.Managers.ConfigManager.getConfigBoolean("CustomJobs"))
            {
                Classes.BlockJobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Implementations.ChickenPluckerJob>("bricks");
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined)]
        public static void AfterItemTypesDefined()
        {
            ItemTypesServer.RegisterChangeTypes("furnace", new List<string>()
                { "furnacex+", "furnacex-", "furnacez+", "furnacez-", "furnacelitx+", "furnacelitx-", "furnacelitz+", "furnacelitz-" }
);
            ItemTypesServer.RegisterChangeTypes("oven", new List<string>()
                { "ovenx+", "ovenz+", "ovenx-", "ovenz-", "ovenlitx+", "ovenlitz+", "ovenlitx-", "ovenlitz-" }
            );



            //Custom jobs!
            if (Classes.Managers.ConfigManager.getConfigBoolean("CustomJobs"))
            {
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnTryChangeBlockUser)]
        public static bool OnTryChangeBlockUser(ModLoader.OnTryChangeBlockUserData d)
        {
             bool allowed = Classes.Managers.WorldManager.AllowPlaceBlock(d);

            Chat.Send(Players.GetPlayer(d.requestedBy.ID), "Block place allowed: " + allowed);
            return allowed;
        }
    }
}