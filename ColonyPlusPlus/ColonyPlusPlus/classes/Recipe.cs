using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public static class Recipe
    {


        public static bool AddRecipe(string type, List<InventoryItem> reqs, List<InventoryItem> result, float fuelAmount = 0.0f, bool npcCraft = false)
        {
            switch (type.ToLower())
            {
                case "crafting":
                    RecipeCraftingStatic.AllRecipes.Add(new RecipeCrafting(npcCraft, reqs, result));

                    break;
                case "smelting":
                    RecipeSmelting.AllRecipes.Add(new RecipeFueled(0.0f, reqs, result));

                    break;
                case "minting":
                    RecipeMinting.AllRecipes.Add(new RecipeCrafting(npcCraft, reqs, result));

                    break;
                case "grinding":
                    RecipeGrinding.AllRecipes.Add(new RecipeCrafting(npcCraft, reqs, result));

                    break;
                case "shopping":
                    RecipeShopping.AllRecipes.Add(new RecipeCrafting(npcCraft, reqs, result));

                    break;
                case "baking":
                    RecipeBaking.AllRecipes.Add(new RecipeFueled(0.0f, reqs, result));

                    break;
                default:
                    Utilities.WriteLog("Unable to create recipe of type " + type + " - invalid type");

                    break;
            }

            return true;
        }

        public static InventoryItem Item(string name, int num)
        {
            return new InventoryItem(ItemTypes.IndexLookup.GetIndex(name), num);
        }

    }
}
