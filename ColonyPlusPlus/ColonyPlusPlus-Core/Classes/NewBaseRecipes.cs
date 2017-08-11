using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Classes.Helpers
{
    class NewBaseRecipes
    {
        public void AddCraftingRecipes()
        {
            RecipeManager.AddRecipe("blacksmithing",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1),
                    RecipeManager.Item("ironingot", 1),
                    RecipeManager.Item("feather", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("arrow", 12)
                },
                0.0f, true);

            RecipeManager.AddRecipe("masonry",
               new List<InventoryItem> {
                    RecipeManager.Item("stoneblock", 1)
               },
               new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 1)
               },
               0.0f,true, true);

            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("flour", 5),
                    RecipeManager.Item("waterbottle", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bread", 2),
                    RecipeManager.Item("bottle", 1)
                },
                0.26f);

        }
        public void AddShoppingRecipes()
        {
            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("grasstaiga", 10)
                },
                0.0f, true);
        }
    }
}
