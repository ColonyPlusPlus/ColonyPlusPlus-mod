using System;
using System.Collections.Generic;

namespace ColonyPlusPlusCore.Managers
{
    public static class RecipeManager
    {

        /// <summary>
        /// Process all these added recipes
        /// </summary>
        public static void ProcessRecipes()
        {

            ColonyAPI.Managers.JobManager.RegisterJobType("blacksmithing", "cpp.blacksmith");
            ColonyAPI.Managers.JobManager.RegisterJobType("carpentry", "cpp.carpenter");
            ColonyAPI.Managers.JobManager.RegisterJobType("pottery", "cpp.potter");
            ColonyAPI.Managers.JobManager.RegisterJobType("masonry", "cpp.stonemason");
            ColonyAPI.Managers.JobManager.RegisterJobType("chickenplucking", "cpp.chickenplucker");
            ColonyAPI.Managers.JobManager.RegisterJobType("well", "cpp.welloperator");

            // Log the number of added recipes
            ColonyAPI.Helpers.Utilities.WriteLog("ColonyPlusPlus", "Added Recipe Mappings");

        }


        /// <summary>
        /// Register all base game recipes (yes - we added them all here...)
        /// </summary>
        public static void AddBaseRecipes()
        {

            Classes.NewBaseRecipes nbr = new Classes.NewBaseRecipes();
            nbr.AddCraftingRecipes();
            nbr.AddShoppingRecipes();
        }
    }
}
