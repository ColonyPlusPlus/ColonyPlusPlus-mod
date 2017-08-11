using System;
using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class RecipeManager
    {

        // list of classes.recipe objects
        public static List<ColonyAPI.Classes.Recipe> recipeList = new List<ColonyAPI.Classes.Recipe>();

        // List of all item classes, registered by the callback
        public static List<ColonyAPI.Classes.Type> TypesThatHaveRecipes = new List<ColonyAPI.Classes.Type>();

        // Keep a count of all added recipes (just to output to the user later)
        public static int recipesAdded = 0;

        //public static Dictionary<string, List<Recipe>> craftingRecipes = new Dictionary<string, List<Recipe>>();
        //public static Dictionary<string, List<RecipeFueled>> craftingRecipesFueled = new Dictionary<string, List<RecipeFueled>>();

        // Add a new recipe object to the list, this is called by the type's AddRecipes() function
        public static bool AddRecipe(string type, List<InventoryItem> reqs, List<InventoryItem> result, float fuelAmount = 0.0f, bool npcCraft = false, bool playerCraft = false)
        {
            //Utilities.WriteLog(ItemTypes.GetNamePrintable(result[0].Type));
            // Pass the variables
            ColonyAPI.Classes.Recipe r = new ColonyAPI.Classes.Recipe(type, reqs, result, fuelAmount, npcCraft, playerCraft);

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
            foreach (ColonyAPI.Classes.Type t in TypesThatHaveRecipes)
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
            List<global::RecipeFueled> RecipeSmelting = new List<global::RecipeFueled>();
            List<global::Recipe> RecipeMinting = new List<global::Recipe>();
            List<global::Recipe> RecipeGrinding = new List<global::Recipe>();
            List<global::Recipe> RecipeShopping = new List<global::Recipe>();
            List<global::RecipeFueled> RecipeBaking = new List<global::RecipeFueled>();
            List<global::Recipe> RecipePottery = new List<global::Recipe>();
            List<global::Recipe> RecipeCarpentry = new List<global::Recipe>();
            List<global::Recipe> RecipeMasonry = new List<global::Recipe>();
            List<global::Recipe> RecipeSmithing = new List<global::Recipe>();
            List<global::Recipe> RecipeTailoring = new List<global::Recipe>();
            List<global::Recipe> RecipeTechnologist = new List<global::Recipe>();
            List<global::Recipe> PlayerRecipes = new List<global::Recipe>();
            List<global::Recipe> RecipeChickenCoop = new List<global::Recipe>();
            List<global::Recipe> RecipeWell = new List<global::Recipe>();

            // Go through each registered recipe class
            foreach (ColonyAPI.Classes.Recipe RecipeInstance in recipeList)
            {
                if (RecipeInstance.PlayerCraftable == true)
                {
                    global::RecipePlayer.AllRecipes.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                    
                }

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
                        //Utilities.WriteLog("Added a smelting recipe!");
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

                    case "tailoring":
                        RecipeTailoring.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    case "technologist":
                        RecipeTechnologist.Add(new global::Recipe(RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    case "baking":
                        RecipeBaking.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    case "pottery":
                        RecipePottery.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    case "carpentry":
                        RecipeCarpentry.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    case "masonry":
                        RecipeMasonry.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    case "blacksmithing":
                        RecipeSmithing.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    case "chickenplucker":
                        RecipeChickenCoop.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    case "well":
                        RecipeWell.Add(new RecipeFueled(RecipeInstance.FuelCost, RecipeInstance.Requirements, RecipeInstance.Results));
                        recipesAdded += 1;
                        break;

                    default:
                        // if the type isn't registered (or is something random) then just say "nah ain't happenin' man"
                        Utilities.WriteLog("Unable to create recipe of type " + RecipeInstance.Type + " - invalid type");
                        break;
                } 
            }

            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.crafter", RecipeCraftingStatic);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.grinder", RecipeGrinding);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.minter", RecipeMinting);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.merchant", RecipeShopping);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.tailor", RecipeTailoring);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.technologist", RecipeTechnologist);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipesFueled("cpp.smelter", RecipeSmelting);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipesFueled("cpp.baker", RecipeBaking);


            // custom jobs
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.blacksmith", RecipeSmithing);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.carpenter", RecipeCarpentry);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.potter", RecipePottery);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.stonemason", RecipeMasonry);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.chickenplucker", RecipeChickenCoop);
            Pipliz.APIProvider.Recipes.RecipeManager.AddRecipes("cpp.welloperator", RecipeWell);

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
            /*try
            {
                ushort u;
                ItemTypes.IndexLookup.TryGetIndex(name, out u);
                InventoryItem i = new InventoryItem(u, num);
                return i;
            } catch (Exception e)
            {
                Utilities.WriteLog("Error finding " + name);
            }

            return new InventoryItem(0, 0);
            */
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
            br.AddAllRecipes();

            Helpers.NewBaseRecipes nbr = new Helpers.NewBaseRecipes();
            nbr.AddCraftingRecipes();
            nbr.AddShoppingRecipes();
        }
    }
}
