using Pipliz;
using Pipliz.Chatting;
using Pipliz.JSON;
using Pipliz.Threading;
using ColonyPlusPlus;
using static Players;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using System;

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

        public static Version modVersion = new Version(0, 2, 0);

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup)]
        public static void AfterStartup()
        {
            Pipliz.Log.Write("<b><color=yellow>Loaded ColonyPlusPlus v" + modVersion.ToString() + "</color></b>");
            Classes.Managers.VersionManager.runVersionCheck(modVersion);

            // Initialise configuration
            Classes.Managers.ConfigManager.initialise();
            Classes.Managers.RotatingMessageManager.initialise();


        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnected)]
        public static void OnPlayerConnected(Player p)
        {
            Chat.Send(p, "Welcome to ColonyPlusPlus, the first mod for Colony Survival to implement the new Modding API. If you have any questions please see our Steam Forum thread or the GitHub repository.");
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
            Classes.Managers.CropManager.register();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesServer)]
        public static void AfterItemTypesServer()
        {
            // Register Tracked Block Types (Wheat?)
            Classes.Managers.TypeManager.registerTrackedTypes();

            // Register Chat Commands
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.Creative());
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.Clear());
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.ChunkCommands());
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.Online());
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.Trade());
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.TradeAccept());
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.TradeReject());
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.TradeGive());
            ChatCommands.CommandManager.RegisterCommand(new Classes.ChatCommands.WorldEdit());
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad)]
        public static void AfterWorldLoad()
        {
            Classes.Managers.RecipeManager.AddBaseRecipes();
            Classes.Managers.RecipeManager.BuildRecipeList();
            Classes.Managers.RecipeManager.ProcessRecipes();

            Classes.Managers.CropManager.LoadCropTracker();
            Classes.Managers.WorldManager.LoadJSON();
        }

        // things to do every tick (or itnerval)
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnUpdate)]
        public static void OnUpdate()
        {
            if(Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdate)
            {
                // do stuff

                // update any crops
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
            Classes.Managers.CropManager.SaveCropTracker();
        }
    }
}