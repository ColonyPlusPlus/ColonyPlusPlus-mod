using System.Collections.Generic;

namespace ColonyPlusPlus.classes.Managers
{
    public static class RecipeManager
    {

        public static List<Recipe> recipeList = new List<Recipe>();
        public static int recipesAdded = 0;


        public static bool AddRecipe(string type, List<InventoryItem> reqs, List<InventoryItem> result, float fuelAmount = 0.0f, bool npcCraft = false)
        {
            Recipe r = new Recipe(type, reqs, result, fuelAmount, npcCraft);
            recipeList.Add(r);
            return true;
        }


        public static void ProcessRecipes()
        {
            foreach (Recipe RecipeInstance in recipeList)
            {
                switch (RecipeInstance.Type.ToLower())
                {
                    case "crafting":
                        RecipeCraftingStatic.AllRecipes.Add(new RecipeCrafting(RecipeInstance.NPCCraftable, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "smelting":
                        RecipeSmelting.AllRecipes.Add(new RecipeFueled(0.0f, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "minting":
                        RecipeMinting.AllRecipes.Add(new RecipeCrafting(RecipeInstance.NPCCraftable, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "grinding":
                        RecipeGrinding.AllRecipes.Add(new RecipeCrafting(RecipeInstance.NPCCraftable, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "shopping":
                        RecipeShopping.AllRecipes.Add(new RecipeCrafting(RecipeInstance.NPCCraftable, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "baking":
                        RecipeBaking.AllRecipes.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    default:
                        Utilities.WriteLog("Unable to create recipe of type " + RecipeInstance.Type + " - invalid type");

                        break;
                }

                
            }

            Utilities.WriteLog("Added " + recipesAdded + " recipes");

        }

        public static InventoryItem Item(string name, int num)
        {
            return new InventoryItem(ItemTypes.IndexLookup.GetIndex(name), num);
        }


        
        public static void AddBaseRecipes()
        {
            BaseRecipes br = new BaseRecipes();

            br.AddCraftingRecipes();
            br.AddBakingRecipes();
            br.AddGrindingRecipes();
            br.AddMintingRecipes();
            br.AddShoppingRecipes();
            br.AddSmeltingRecipes();
        }
    }
}
