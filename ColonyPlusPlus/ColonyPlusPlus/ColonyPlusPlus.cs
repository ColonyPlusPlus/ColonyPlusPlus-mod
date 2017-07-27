using Pipliz;
using Pipliz.Chatting;
using Pipliz.JSON;
using Pipliz.Threading;
using ColonyPlusPlus;
using static Players;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace ColonyPlusPlus
{
    [ModLoader.ModManager]
    public class ColonyPlusPlus
    {

        private static long nextMillisecondUpdate = 0;
        private static long nextMillisecondUpdateLong = 0;
        private static long millisecondDelta = 500;

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup)]
        public static void AfterStartup()
        {
            Pipliz.Log.Write("Loaded ColonyPlusPlus v0.1.3");
            
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnPlayerConnected)]
        public static void OnPlaterConnected(Player p)
        {
            //Chat.Send(p.ID, "Welcome to ColonyPlusPlus, the first mod for Colony Survival to implement the new Modding API. If you have any questions please see our Steam Forum thread or the GitHub repository.");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes)]
        public static void AfterAddingBaseTypes()
        {
            
            // Register Materials
            classes.Managers.MaterialManager.initialiseMaterials();

            // Register basegame types
            classes.Managers.BaseGameManager.registerBlocks();
            classes.Managers.BaseGameManager.registerItems();

            // Register types
            classes.Managers.BlockManager.register();
            classes.Managers.ItemManager.register();
            classes.Managers.CropManager.register();
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterItemTypesServer)]
        public static void AfterItemTypesServer()
        {
            // Register Tracked Block Types (Wheat?)
            classes.Managers.TypeManager.registerTrackedTypes();

            // Register Chat Commands
            ChatCommands.CommandManager.RegisterCommand(new classes.ChatCommands.Creative());
            ChatCommands.CommandManager.RegisterCommand(new classes.ChatCommands.Clear());
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterWorldLoad)]
        public static void AfterWorldLoad()
        {
            classes.Managers.RecipeManager.AddBaseRecipes();
            classes.Managers.RecipeManager.BuildRecipeList();
            classes.Managers.RecipeManager.ProcessRecipes();

            classes.Managers.CropManager.LoadCropTracker();
        }

        // things to do every tick (or itnerval)
        [ModLoader.ModCallback(ModLoader.EModCallbackType.OnUpdate)]
        public static void OnUpdate()
        {
            if(Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdate)
            {
                // do stuff

                // update any crops
                classes.Managers.CropManager.doCropUpdates();

                // set the next update time!
                nextMillisecondUpdate = Pipliz.Time.MillisecondsSinceStart + millisecondDelta;
            }

            // Run once a minute
            if (Pipliz.Time.MillisecondsSinceStart > nextMillisecondUpdateLong)
            {

                // save out crop progress to file
                classes.Managers.CropManager.SaveCropTrackerInterval();

                // long term update time
                nextMillisecondUpdateLong = Pipliz.Time.MillisecondsSinceStart +  60000;
            }


        }
        //[ModLoader.ModCallback(ModLoader.EModCallbackType.)]
    }
}