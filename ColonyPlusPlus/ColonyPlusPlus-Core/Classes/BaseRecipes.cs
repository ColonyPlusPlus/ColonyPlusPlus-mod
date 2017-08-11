using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Classes
{
    public class BaseRecipes
    {

        public void AddAllRecipes()
        {
            AddBakingRecipes();
            AddCraftingRecipes();
            AddGrindingRecipes();
            AddMintingRecipes();
            AddShoppingRecipes();
            AddSmeltingRecipes();
            AddTailoringRecipes();
            AddTechnologistRecipes();
        }


        /// <summary>
        /// Add basegame crafting recipes
        /// </summary>
        public void AddCraftingRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 3),
                    ColonyAPI.Managers.RecipeManager.Item("straw", 3)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("bed", 1)
                },
                true, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("crate", 1)
                },
                true, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("quiver", 2)
                },
                true, true);

            /// <summary>
            /// 2 planks = 1 bow
            /// </summary>
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 2),
                    ColonyAPI.Managers.RecipeManager.Item("flax", 2)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("bow", 1)
                },
                true, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("coatedplanks", 1),
                    ColonyAPI.Managers.RecipeManager.Item("ironingot", 1),
                    ColonyAPI.Managers.RecipeManager.Item("linenbag", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("technologisttable", 1)
                },
                true, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("masonry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("furnace", 1)
                },
               true, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("masonry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("oven", 1)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("stonebricks", 1),
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("grindstone", 1)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logtemperate", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 4)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logtaiga", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 4)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 1),
				    ColonyAPI.Managers.RecipeManager.Item("coalore", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("torch", 1)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("workbench", 1)
                },
                 true, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 1),
                    ColonyAPI.Managers.RecipeManager.Item("ironingot", 1),
                    ColonyAPI.Managers.RecipeManager.Item("flax", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("tailorshop", 1)
                },
                 true, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("blacksmithing",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("planks", 1),
                    ColonyAPI.Managers.RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("arrow", 4)
                },
                 true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("blacksmithing",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1),
				    ColonyAPI.Managers.RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("pickaxe", 1)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("blacksmithing",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1),
				    ColonyAPI.Managers.RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("axe", 1)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1),
				    ColonyAPI.Managers.RecipeManager.Item("ironingot", 1),
				    ColonyAPI.Managers.RecipeManager.Item("goldingot", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("mint", 1)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 5),
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1),
				    ColonyAPI.Managers.RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("shop", 1)
                },
                 true, true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("flax", 5)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("linseedoil", 1)
                },
                 true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("carpentry",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("linseedoil", 1),
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("coatedplanks", 1)
                },
                 true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("linseedoil", 1),
				    ColonyAPI.Managers.RecipeManager.Item("dirt", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("adobe", 1)
                },
                 true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("masonry",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("gypsum", 1),
				    ColonyAPI.Managers.RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("plasterblock", 1)
                },
                 true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("berry", 1),
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("redplanks", 1)
                },
                 true);
			
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
				    ColonyAPI.Managers.RecipeManager.Item("coalore", 1),
				    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("blackplanks", 1)
                },
                 true);

        }
        

        // Baking Recipes
        public void AddBakingRecipes()
        {
            
        }

        // Grinding Recipes
        public void AddGrindingRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("grinding",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("wheat", 2)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("flour", 2)
                },
                );
        }

        // Grinding Recipes
        public void AddMintingRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("minting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldingot", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 2)
                },
                ); 
        }

        // Shopping Recipes
        public void AddShoppingRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 20)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("flaxstage1", 10)
                },
                );

            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 10)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("cherrysapling", 1)
                },
                );

            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 300)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("berrybush", 10)
                },
                );

            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 12)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("wheatstage1", 6)
                },
                );

            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 3)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("dirt", 10)
                },
                );

            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 3)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("grasstemperate", 10)
                },
                );

        }

        // Smelting Recipes
        public void AddSmeltingRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipeFueled("smelting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("ironore", 3)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("ironingot", 1)
                },
                0.2f);

            ColonyAPI.Managers.RecipeManager.AddRecipeFueled("smelting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldore", 3)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldingot", 1)
                },
                0.2f);

            ColonyAPI.Managers.RecipeManager.AddRecipeFueled("pottery",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("clay", 3)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("bricks", 3)
                },
                0.2f);
        }

        // Tailoring Recipes
        public void AddTailoringRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("tailoring",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("flax", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("linen", 1)
                },
                );

            ColonyAPI.Managers.RecipeManager.AddRecipe("tailoring",
               new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("linen", 3)
               },
               new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("clothing", 1)
               },
               );

            ColonyAPI.Managers.RecipeManager.AddRecipe("tailoring",
               new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("linen", 3)
               },
               new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("linenbag", 1)
               },
               );

            ColonyAPI.Managers.RecipeManager.AddRecipe("tailoring",
               new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("flax", 1),
                    ColonyAPI.Managers.RecipeManager.Item("linen", 1),
                    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
               },
               new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("carpetblue", 1)
               },
               );

            ColonyAPI.Managers.RecipeManager.AddRecipe("tailoring",
              new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("flax", 1),
                    ColonyAPI.Managers.RecipeManager.Item("linen", 1),
                    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
              },
              new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("carpetred", 1)
              },
              );

            ColonyAPI.Managers.RecipeManager.AddRecipe("tailoring",
              new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("flax", 1),
                    ColonyAPI.Managers.RecipeManager.Item("linen", 1),
                    ColonyAPI.Managers.RecipeManager.Item("planks", 1)
              },
              new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("carpetyellow", 1)
              },
              );

        }

        // Techhnologist Recipes
        public void AddTechnologistRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("technologist",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("bread", 1),
                    ColonyAPI.Managers.RecipeManager.Item("berry", 5),
                    ColonyAPI.Managers.RecipeManager.Item("clothing", 1),
                    ColonyAPI.Managers.RecipeManager.Item("linenbag", 1),
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("sciencebaglife", 2)
                },
                );

            ColonyAPI.Managers.RecipeManager.AddRecipe("technologist",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("ironingot", 1),
                    ColonyAPI.Managers.RecipeManager.Item("bricks", 3),
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 1),
                    ColonyAPI.Managers.RecipeManager.Item("linenbag", 1),
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("sciencebagbasic", 2)
                },
                );
        }
    }
}
