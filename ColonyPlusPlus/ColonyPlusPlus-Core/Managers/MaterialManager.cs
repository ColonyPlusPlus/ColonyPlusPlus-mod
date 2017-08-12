namespace ColonyPlusPlusCore.Managers
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

            ColonyAPI.Managers.MaterialManager.createMaterial("marble", "graymarble", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("grasstemperateside", "grassTemperateSide", "neutral", "grassGenericSide", "grassGenericSide");
        }
    }
}
