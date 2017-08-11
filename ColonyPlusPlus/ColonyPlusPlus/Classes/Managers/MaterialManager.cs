namespace ColonyPlusPlus.Classes.Managers
{
    public static class MaterialManager
    {
        /// <summary>
        /// Function to initialise new materials
        /// </summary>
        public static void initialiseMaterials()
        {
            Material.createMaterial("wildberrybush", "wildberrybush", "neutral", "berrybush", "berrybush");
            Material.createMaterial("vegetablepatch", "leavesTemperate", "neutral", "leavesTemperate", "leavesTemperate");
            Material.createMaterial("sugarcane", "clayblocklime", "neutral", "leavesTemperate", "leavesTemperate");


            Material.createMaterial("cpplogtemperatetop", "cpplogtemperatetop", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("cpplogtemperate", "cpplogtemperate", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("cpplogtaiga", "cpplogtaiga", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("cpplogtaigatop", "cpplogtaigatop", "neutral", "plasterblock", "plasterblock");

            // job stuff
            Material.createMaterial("welltop", "well", "neutral", "well", "plasterblock");
            Material.createMaterial("masontable", "masontable", "neutral", "masontable", "plasterblock");
            Material.createMaterial("carpentrytable", "carpentrytable", "neutral", "carpentrytable", "plasterblock");

            // Decorative blocks
            Material.createMaterial("clayblock", "clayblock", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockblack", "clayblockblack", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockblue", "clayblockblue", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockbrown", "clayblockbrown", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockcyan", "clayblockcyan", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockgray", "clayblockgray", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockgreen", "clayblockgreen", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblocklightblue", "clayblocklightblue", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblocklime", "clayblocklime", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockmagenta", "clayblockmagenta", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockorange", "clayblockorange", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockpink", "clayblockpink", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockpurple", "clayblockpurple", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockred", "clayblockred", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblocksilver", "clayblocksilver", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockwhite", "clayblockwhite", "neutral", "plasterblock", "plasterblock");
            Material.createMaterial("clayblockyellow", "clayblockyellow", "neutral", "plasterblock", "plasterblock");

            Material.createMaterial("marble", "graymarble", "neutral", "neutral", "neutral");
            Material.createMaterial("grasstemperateside", "grassTemperateSide", "neutral", "grassGenericSide", "grassGenericSide");
        }
    }
}
