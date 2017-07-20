using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public class BaseRecipes
    {
        //Crafting Recipes
        public void AddCraftingRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 3),
                    RecipeManager.Item("straw", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bed", 1)
                },
                0.0f, true);

            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("crate", 1)
                },
                0.0f, true);

            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("quiver", 2)
                },
                0.0f, true);

            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bow", 1)
                },
                0.0f, true);

            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("furance", 1)
                },
                0.0f, true);

            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("oven", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 1),
				    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("grindstone", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtemperate", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 4)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtaiga", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 4)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("coalore", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("torch", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("workbench", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("arrow", 8)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("pickaxe", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("axe", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("ironingot", 1),
				    RecipeManager.Item("goldingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("mint", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("goldcoin", 5),
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("shop", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("flax", 5)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("lineseedoil", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("lineseedoil", 1),
				    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("coatedplanks", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("lineseedoil", 1),
				    RecipeManager.Item("dirt", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("adobe", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("gypsum", 1),
				    RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("plasterblock", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("berry", 1),
				    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("redplanks", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("coalore", 1),
				    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("blackplanks", 1)
                },
                0.0f, true);

        }
        

        // Baking Recipes
        public void AddBakingRecipes()
        {
            RecipeManager.AddRecipe("grinding",
                new List<InventoryItem> {
                    RecipeManager.Item("flour", 5)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bread", 2)
                },
                0.26f);
        }

        // Grinding Recipes
        public void AddGrindingRecipes()
        {
            RecipeManager.AddRecipe("grinding",
                new List<InventoryItem> {
                    RecipeManager.Item("wheat", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("flour", 2)
                },
                0.0f);
        }

        // Grinding Recipes
        public void AddMintingRecipes()
        {
            RecipeManager.AddRecipe("minting",
                new List<InventoryItem> {
                    RecipeManager.Item("goldingot", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 2)
                },
                0.0f); 
        }

        // Shopping Recipes
        public void AddShoppingRecipes()
        {
            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 200)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("flaxstage1", 100)
                },
                0.0f);

            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 10)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("cherrysapling", 1)
                },
                0.0f);

            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 300)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("berrybush", 10)
                },
                0.0f);

            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 12)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("wheatstage1", 6)
                },
                0.0f);

            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("dirt", 10)
                },
                0.0f);

            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("grasstemperate", 10)
                },
                0.0f);

        }

        // Smelting Recipes
        public void AddSmeltingRecipes()
        {
            RecipeManager.AddRecipe("smelting",
                new List<InventoryItem> {
                    RecipeManager.Item("ironore", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("ironingot", 1)
                },
                0.2f);

            RecipeManager.AddRecipe("smelting",
                new List<InventoryItem> {
                    RecipeManager.Item("goldore", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("goldingot", 1)
                },
                0.2f);

            RecipeManager.AddRecipe("smelting",
                new List<InventoryItem> {
                    RecipeManager.Item("clay", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bricks", 3)
                },
                0.2f);
        }
    }
}
