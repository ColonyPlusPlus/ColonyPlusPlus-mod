using Pipliz.Chatting;
using System;
using System.Collections.Generic;
using ColonyPlusPlusDecorative.Classes;

namespace ColonyPlusPlusDecorative
{
    [ModLoader.ModManager]
    public class ColonyPlusPlusDecorative
    {
        
        private static int plyID = 0;
        public static Version modVersion = new Version(0, 2, 0, 2);


        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "colonyplusplusdecorative.initialise")]
        [ModLoader.ModCallbackDependsOn("colonyapi.initialise")]
        public static void AfterStartup()
        {

            ColonyAPI.Managers.VersionManager.addVersionURL("ColonyPlusPlus-Decorative", "https://raw.githubusercontent.com/ColonyPlusPlus/ColonyPlusPlus/master/docs/currentversion_decorative.md");
            ColonyAPI.Managers.VersionManager.runVersionCheck("ColonyPlusPlus-Decorative", modVersion);

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Decorative", "Loaded ColonyPlusPlus Decorative v" + modVersion.ToString(), ColonyAPI.Helpers.Chat.ChatColour.yellow, ColonyAPI.Helpers.Chat.ChatStyle.normal);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes, "colonyplusplusdecorative.AfterAddingBaseTypesMaterials")]
        [ModLoader.ModCallbackProvidesFor("colonyapi.registerMaterials")]
        public static void AfterAddingBaseTypes()
        {

            // Register Materials
            Managers.MaterialManager.initialiseMaterials();

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Decorative", "Registered Materials");
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes, "colonyplusplusdecorative.AfterAddingBaseTypesBlocks")]
        [ModLoader.ModCallbackProvidesFor("colonyapi.discoverTypes")]
        public static void RegisterTypes()
        {
            // Register Types
            Managers.BlockManager.register();

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Decorative", "Registered Blocks");
        }

    }
}