namespace ColonyPlusPlus.classes.Managers
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
        }
    }
}
