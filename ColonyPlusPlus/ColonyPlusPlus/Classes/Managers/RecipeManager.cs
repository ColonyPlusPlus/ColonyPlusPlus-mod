using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class RecipeManager
    {

        // list of classes.recipe objects
        public static List<Recipe> recipeList = new List<Recipe>();

        // List of all item classes, registered by the callback
        public static List<Classes.Type> TypesThatHaveRecipes = new List<Classes.Type>();

        // Keep a count of all added recipes (just to output to the user later)
        public static int recipesAdded = 0;

        //public static Dictionary<string, List<Recipe>> craftingRecipes = new Dictionary<string, List<Recipe>>();
        //public static Dictionary<string, List<RecipeFueled>> craftingRecipesFueled = new Dictionary<string, List<RecipeFueled>>();

        // Add a new recipe object to the list, this is called by the type's AddRecipes() function
        public static bool AddRecipe(string type, List<InventoryItem> reqs, List<InventoryItem> result, float fuelAmount = 0.0f, bool npcCraft = false)
        {
            // Pass the variables
            Recipe r = new Recipe(type, reqs, result, fuelAmount, npcCraft);

            // Add it to the list
            recipeList.Add(r);
            return true;
        }

        /// <summary>
        /// Build the recipe list using the callback registered class list
        /// </summary>
        public static void BuildRecipeList()
        {
            // Loop through
            foreach (Type t in TypesThatHaveRecipes)
            { 
                // Add it :)
                t.AddRecipes();
            }
        }

        /// <summary>
        /// Process all these added recipes
        /// </summary>
        public static void ProcessRecipes()
        {
            List<global::Recipe> RecipeCraftingStatic = new List<global::Recipe>();
            List<global::Recipe> RecipeSmelting = new List<global::Recipe>();
            List<global::Recipe> RecipeMinting = new List<global::Recipe>();
            List<global::Recipe> RecipeGrinding = new List<global::Recipe>();
            List<global::Recipe> RecipeShopping = new List<global::Recipe>();
            List<global::Recipe> RecipeBaking = new List<global::Recipe>();

            // Go through each registered recipe class
            foreach (Recipe RecipeInstance in recipeList)
            {
                // Switch depending on the "type" registered in the recipe class
                switch (RecipeInstance.Type.ToLower())
                {
                    case "crafting":
  //                      
                        RecipeCraftingStatic.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        
                        break;
                    case "smelting":
                        RecipeSmelting.Add(new global::RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "minting":
                        RecipeMinting.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "grinding":
                        RecipeGrinding.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "shopping":
                        RecipeShopping.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "baking":
                        RecipeBaking.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;

                        break;
                    case "chickenplucker":
                        recipesAdded += 1;
                        break;
                    default:
                        // if the type isn't registered (or is something random) then just say "nah ain't happenin' man"
                        Utilities.WriteLog("Unable to create recipe of type " + RecipeInstance.Type + " - invalid type");

                        break;
                }

                
            }

            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("pipliz.crafter", RecipeCraftingStatic);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("pipliz.grinder", RecipeGrinding);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("pipliz.minter", RecipeMinting);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("pipliz.merchant", RecipeShopping);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("pipliz.smelter", RecipeSmelting);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("pipliz.baker", RecipeBaking);

            // Log the number of added recipes
            Utilities.WriteLog("Added " + recipesAdded + " recipes");

        }

        /// <summary>
        /// Just a function that performs the item lookup nicely
        /// </summary>
        /// <param name="name">Item name (as it is registered)</param>
        /// <param name="num">The number the inventory should contain</param>
        /// <returns></returns>
        public static InventoryItem Item(string name, int num)
        {
            return new InventoryItem(ItemTypes.IndexLookup.GetIndex(name), num);
        }


        /// <summary>
        /// Register all base game recipes (yes - we added them all here...)
        /// </summary>
        public static void AddBaseRecipes()
        {
            // instantiate the BaseRecipes class
            BaseRecipes br = new BaseRecipes();

            // I'm sure you can figure this out ;)
            br.AddCraftingRecipes();
            br.AddBakingRecipes();
            br.AddGrindingRecipes();
            br.AddMintingRecipes();
            br.AddShoppingRecipes();
            br.AddSmeltingRecipes();

            Helpers.NewBaseRecipes nbr = new Helpers.NewBaseRecipes();
            nbr.AddCraftingRecipes();
            nbr.AddShoppingRecipes();
        }
    }
}
