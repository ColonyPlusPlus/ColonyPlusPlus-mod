namespace ColonyPlusPlusCore.Classes.Managers
{
    public static class MaterialManager
    {
        /// <summary>
        /// Function to initialise new materials
        /// </summary>
        public static void initialiseMaterials()
        {
            ColonyAPI.Managers.MaterialManager.createMaterial("wildberrybush", "wildberrybush", "neutral", "berrybush", "berrybush");
            ColonyAPI.Managers.MaterialManager.createMaterial("vegetablepatch", "leavesTemperate", "neutral", "leavesTemperate", "leavesTemperate");
            ColonyAPI.Managers.MaterialManager.createMaterial("sugarcane", "clayblocklime", "neutral", "leavesTemperate", "leavesTemperate");


            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogtemperatetop", "cpplogtemperatetop", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogtemperate", "cpplogtemperate", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogtaiga", "cpplogtaiga", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogtaigatop", "cpplogtaigatop", "neutral", "plasterblock", "plasterblock");

            // job stuff
            ColonyAPI.Managers.MaterialManager.createMaterial("welltop", "well", "neutral", "well", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("masontable", "masontable", "neutral", "masontable", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("carpentrytable", "carpentrytable", "neutral", "carpentrytable", "plasterblock");

            // Decorative blocks
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblock", "clayblock", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockblack", "clayblockblack", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockblue", "clayblockblue", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockbrown", "clayblockbrown", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockcyan", "clayblockcyan", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockgray", "clayblockgray", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockgreen", "clayblockgreen", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblocklightblue", "clayblocklightblue", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblocklime", "clayblocklime", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockmagenta", "clayblockmagenta", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockorange", "clayblockorange", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockpink", "clayblockpink", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockpurple", "clayblockpurple", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockred", "clayblockred", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblocksilver", "clayblocksilver", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockwhite", "clayblockwhite", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("clayblockyellow", "clayblockyellow", "neutral", "plasterblock", "plasterblock");

            ColonyAPI.Managers.MaterialManager.createMaterial("marble", "graymarble", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("grasstemperateside", "grassTemperateSide", "neutral", "grassGenericSide", "grassGenericSide");
        }
    }
}
