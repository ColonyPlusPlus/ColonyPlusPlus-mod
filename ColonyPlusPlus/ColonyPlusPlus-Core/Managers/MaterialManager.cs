using ColonyAPI.Managers;

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
            ColonyAPI.Managers.MaterialManager.createMaterial("sugarcane", "grassTemperate", "neutral", "leavesTemperate", "leavesTemperate");


            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogtemperatetop", 
                GetAlbedo(ColonyPlusPlus.ModDir,"cpplogtemperatetop"), 
                "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogtemperate", 
                GetAlbedo(ColonyPlusPlus.ModDir, "cpplogtemperate"), 
                "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogtaiga",
                GetAlbedo(ColonyPlusPlus.ModDir, "cpplogtaiga"), 
                "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogtaigatop",
                GetAlbedo(ColonyPlusPlus.ModDir, "cpplogtaigatop"), 
                "neutral", "plasterblock", "plasterblock");

            //ColonyAPI.Managers.MaterialManager.createMaterial("cpplogbirch", "birch", "neutral", "plasterblock", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("cpplogbirch", 
                GetAlbedo(ColonyPlusPlus.ModDir, "birch"), 
                "neutral", "plasterblock", "plasterblock");

            // job stuff
            ColonyAPI.Managers.MaterialManager.createMaterial("welltop",
                GetAlbedo(ColonyPlusPlus.ModDir, "well"),
                "neutral", "well", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("masontable", "masontable", "neutral", "masontable", "plasterblock");
            ColonyAPI.Managers.MaterialManager.createMaterial("carpentrytable", "carpentrytable", "neutral", "carpentrytable", "plasterblock");

            ColonyAPI.Managers.MaterialManager.createMaterial("marble", "graymarble", "neutral", "neutral", "neutral");
            ColonyAPI.Managers.MaterialManager.createMaterial("grasstemperateside", 
                GetAlbedo(ColonyPlusPlus.ModDir, "grassTemperateSide"), 
                "neutral", "grassGenericSide", "grassGenericSide");
        }
        public static string GetAlbedo(string modfolder, string file)
        {
            return "../../../../mods/" + modfolder + "/textures/materials/blocks/albedo/" + file;
        }
        public static string GetEmissive(string modfolder, string file)
        {
            return "../../../../mods/" + modfolder + "/textures/materials/blocks/emissiveMaskAlpha/" + file;
        }
        public static string GetHeight(string modfolder, string file)
        {
            return "../../../../mods/" + modfolder + "/textures/materials/blocks/heightSmoothnessSpecularity/" + file;
        }
        public static string GetNormal(string modfolder, string file)
        {
            return "../../../../mods/" + modfolder + "/textures/materials/blocks/normal/" + file;
        }
    }
}
