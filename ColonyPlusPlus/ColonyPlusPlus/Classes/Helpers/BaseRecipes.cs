using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes
{
    public class BaseRecipes
    {

        /// <summary>
        /// Add basegame crafting recipes
        /// </summary>
        public void AddCraftingRecipes()
        {
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 3),
                    RecipeManager.Item("straw", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bed", 1)
                },
                0.0f, true, true);

            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("crate", 1)
                },
                0.0f, true, true);

            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("quiver", 2)
                },
                0.0f, true, true);

            /// <summary>
            /// 2 planks = 1 bow
            /// </summary>
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 2),
                    RecipeManager.Item("flax", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bow", 1)
                },
                0.0f, true, true);

            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("coatedplanks", 1),
                    RecipeManager.Item("ironingot", 1),
                    RecipeManager.Item("linenbag", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("technologisttable", 1)
                },
                0.0f, true, true);

            RecipeManager.AddRecipe("masonry",
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("furnace", 1)
                },
                0.0f, true, true);

            RecipeManager.AddRecipe("masonry",
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("oven", 1)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 1),
				    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("grindstone", 1)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("logtemperate", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 4)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("logtaiga", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 4)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("coalore", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("torch", 1)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("workbench", 1)
                },
                0.0f, true, true);

            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1),
                    RecipeManager.Item("ironingot", 1),
                    RecipeManager.Item("flax", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("tailorshop", 1)
                },
                0.0f, true, true);

            RecipeManager.AddRecipe("blacksmithing",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 1),
                    RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("arrow", 4)
                },
                0.0f, true);

            RecipeManager.AddRecipe("blacksmithing",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("pickaxe", 1)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("blacksmithing",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("axe", 1)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("ironingot", 1),
				    RecipeManager.Item("goldingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("mint", 1)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
				    RecipeManager.Item("goldcoin", 5),
				    RecipeManager.Item("planks", 1),
				    RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("shop", 1)
                },
                0.0f, true, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("flax", 5)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("linseedoil", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
				    RecipeManager.Item("linseedoil", 1),
				    RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("coatedplanks", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    RecipeManager.Item("linseedoil", 1),
				    RecipeManager.Item("dirt", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("adobe", 1)
                },
                0.0f, true);
			
            RecipeManager.AddRecipe("masonry",
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
            RecipeManager.AddRecipe("baking",
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
                    RecipeManager.Item("goldingot", 1)
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
                    RecipeManager.Item("goldcoin", 20)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("flaxstage1", 10)
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

            RecipeManager.AddRecipe("pottery",
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
