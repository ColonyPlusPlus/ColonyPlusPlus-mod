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


        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterStartup, "cpp-decorative.AfterStartup")]
        [ModLoader.ModCallbackProvidesFor("colonyapi.AfterStartup")]
        public static void AfterStartup()
        {
            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus-Decorative", "Loaded ColonyPlusPlus v" + modVersion.ToString(), ColonyAPI.Helpers.Chat.ChatColour.yellow, ColonyAPI.Helpers.Chat.ChatStyle.normal);
            ColonyAPI.Managers.VersionManager.runVersionCheck("ColonyPlusPlus-Decorative", modVersion);    
        }

        [ModLoader.ModCallback(ModLoader.EModCallbackType.AfterAddingBaseTypes, "colonyplusplus.AfterAddingBaseTypes")]
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