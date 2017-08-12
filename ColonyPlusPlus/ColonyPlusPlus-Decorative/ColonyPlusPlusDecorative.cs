using Pipliz.Chatting;
using static Players;
using System;
using System.Collections.Generic;
using ColonyPlusPlusDecorative.Classes;

namespace ColonyPlusPlusDecorative
{
    [ModLoader.ModManager]
    public class ColonyPlusPlus
    {
        
        private static int plyID = 0;
        public static Version modVersion = new Version(0, 2, 0);


        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "colonyplusplusdecorative.AfterStartup")]
        [ModLoader.ModCallbackProvidesFor("colonyapi.AfterStartup")]
        public static void AfterStartup()
        {

            ColonyAPI.Managers.VersionManager.addVersionURL("ColonyPlusPlus-Decorative", "https://raw.githubusercontent.com/ColonyPlusPlus/ColonyPlusPlus/master/docs/currentversion.md");
            ColonyAPI.Managers.VersionManager.runVersionCheck("ColonyPlusPlus-Decorative", modVersion);

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Decorative", "Loaded ColonyPlusPlus Decorative v" + modVersion.ToString(), ColonyAPI.Helpers.Chat.ChatColour.yellow, ColonyAPI.Helpers.Chat.ChatStyle.normal);
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes, "colonyplusplusdecorative.AfterAddingBaseTypes")]
        [ModLoader.ModCallbackProvidesFor("colonyapi.AfterAddingBaseTypes")]
        public static void AfterAddingBaseTypes()
        {
            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Decorative", "Starting AfterAddingBaseTypes");

            // Register Materials
            Managers.MaterialManager.initialiseMaterials();

            // Register Types
            Managers.BlockManager.register();

            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Decorative", "Ending AfterAddingBaseTypes");
        }
      
    }
}