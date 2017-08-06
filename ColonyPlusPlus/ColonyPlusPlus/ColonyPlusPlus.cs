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


        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "colonyplusplus.AfterStartup")]
        public static void AfterStartup()
        {
            Pipliz.Log.Write("<b><color=yellow>Loaded ColonyPlusPlus v" + modVersion.ToString() + "</color></b>");
            Classes.Managers.VersionManager.runVersionCheck(modVersion);

            // Initialise configuration
            Classes.Managers.ConfigManager.initialise();
            Classes.Managers.RotatingMessageManager.initialise();
            Classes.Managers.ServerVariablesManager.init();

            CustomJobs = true; // Classes.Managers.ConfigManager.getConfigBoolean("modules.CustomJobs");
            CustomCrops = true; // Classes.Managers.ConfigManager.getConfigBoolean("modules.CustomCrops");

            // Initialize chat commands
            Classes.Managers.ChatCommandManager.Initialize();

           
            
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnectedLate, "colonyplusplus.OnPlayerConnectedLate")]
        public static void OnPlayerConnectedLate(Player p)
        {
            if(p.ID.steamID.m_SteamID == 0)
            {
                Classes.Helpers.Chat.send(p, Classes.Managers.VersionManager.SinglePlayerrunVersionCheck(modVersion), Classes.Helpers.Chat.ChatColour.red);
            }
            Chat.Send(p, Classes.Managers.ConfigManager.getConfigString("motd.message"));

           

            
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes, "colonyplusplus.AfterAddingBaseTypes")]
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
            {
                Classes.Managers.CropManager.register();
            }
               
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesServer, "colonyplusplus.AfterItemTypesServer" )]
        public static void AfterItemTypesServer()
        {
            // Register Tracked Block Types (Wheat?)
            if (CustomCrops)
            {
                Classes.Managers.TypeManager.registerTrackedTypes();
            }

            // Register our chat parser
            ChatCommands.CommandManager.RegisterCommand(new Classes.Managers.ChatManager());

            // Register Master Command
            ChatCommands.CommandManager.RegisterCommand(new Classes.Managers.MasterChatCommandManager());
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad, "colonyplusplus.AfterWorldLoad")]
        public static void AfterWorldLoad()
        {
            

            if (CustomCrops)
            {
                Classes.Managers.CropManager.LoadCropTracker();
            }
               
            Classes.Managers.WorldManager.LoadJSON();

            //Classes.BlockJobs.BlockJobManagerTracker.AfterWorldLoad();
        }

        // things to do every tick (or itnerval)
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnUpdate, "colonyplusplus.OnUpdate")]
        public static void OnUpdate()
        {
            if(Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdate)
            {
                // do stuff

                // update any crops
                if (CustomCrops)
                {
                    Classes.Managers.CropManager.doCropUpdates();
                }
                    

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
                {
                    Classes.Managers.CropManager.SaveCropTrackerInterval();
                }
                    

                // long term update time
                nextMillisecondUpdateLong = Pipliz.Time.MillisecondsSinceStart +  60000;
            }

            // run the rotator
            Classes.Managers.RotatingMessageManager.doRun();

        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuitEarly, "colonyplusplus.OnQuitEarly")]
        public static void OnQuitEarly()
        {
            if (CustomCrops)
            {
                Classes.Managers.CropManager.SaveCropTracker();
            }
               
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnQuit, "colonyplusplus.OnQuit")]
        public static void OnQuit()
        {
            //Classes.BlockJobs.BlockJobManagerTracker.Save();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterDefiningNPCTypes, "colonyplusplus.AfterDefiningNPCTypes")]
        public static void AfterDefiningNPCTypes()
        {
             if (CustomJobs)
             {
                 Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Blacksmith>("anvil");
                 Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.Carpenter>("sawmill");
                 Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.ChickenPluckerJob>("chickencoop");
                 Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.CraftingJob.StoneMason>("masontable");

                 Pipliz.APIProvider.Jobs.BlockJobManagerTracker.Register<Classes.BlockJobs.FueledCraftingJob.PotteryJob>("potterytable");
             }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesDefined, "colonyplusplus.AfterItemTypesDefined")]
        [ModLoader.ModCallbackDependsOn("pipliz.blocknpcs.loadrecipes")]
        [ModLoader.ModCallbackProvidesFor("pipliz.apiprovider.registerrecipes")]
        public static void AfterItemTypesDefined()
        {
            Classes.Managers.RecipeManager.AddBaseRecipes();
            Classes.Managers.RecipeManager.BuildRecipeList();
            Classes.Managers.RecipeManager.ProcessRecipes();

            
            //Custom jobs!
            if (CustomJobs)
            {
                //RecipeManager.LoadRecipes("cpp.Carpenter", Path.Combine(ModGamedataDirectory, "tailoring.json"));
                //RecipeManager.LoadRecipes("cpp.chickenplucker", Path.Combine(ModGamedataDirectory, "crafting.json"));
                //RecipeManager.LoadRecipes("cpp.StoneMason", Path.Combine(ModGamedataDirectory, "grinding.json"));
                //RecipeManager.LoadRecipes("cpp.Blacksmith", Path.Combine(ModGamedataDirectory, "minting.json"));
                //RecipeManager.LoadRecipesFueled("cpp.Potter", Path.Combine(ModGamedataDirectory, "smelting.json"));
            }
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnTryChangeBlockUser, "colonyplusplus.OnTryChangeBlockUser")]
        public static bool OnTryChangeBlockUser(ModLoader.OnTryChangeBlockUserData d)
        {

            if (d.requestedBy.ID.steamID.m_SteamID == 0)
            {
                return true;
            }
            bool allowed = Classes.Managers.WorldManager.AllowPlaceBlock(d);

            Chat.Send(Players.GetPlayer(d.requestedBy.ID), "Block place allowed: " + allowed);
            return allowed;
        }
    }
}