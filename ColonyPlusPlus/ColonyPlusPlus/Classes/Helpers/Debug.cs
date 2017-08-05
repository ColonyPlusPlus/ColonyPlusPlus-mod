using System;
using System.Collections;
using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.Helpers
{
    public static class Debug
    {
		public static void outputTypes()
		{
			Pipliz.JSON.JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

			foreach (string typename in Managers.TypeManager.AddedTypes)
			{
				Pipliz.JSON.JSONNode outputtype = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

				Pipliz.JSON.JSONNode itemJson = ItemTypes.GetTypesJSON.GetAs<Pipliz.JSON.JSONNode>(typename);

				outputtype.SetAs("icon", outputtype.GetAs<string>("icon"));
				outputtype.SetAs("maxstack", outputtype.GetAs<int>("maxStackSize"));
				outputtype.SetAs("name", typename);
				outputtype.SetAs("newtype", outputtype.GetAs<bool>("newtype"));

				node.SetAs<Pipliz.JSON.JSONNode>(typename, outputtype);
			}

			Pipliz.JSON.JSON.Serialize(Utilities.GetDebugJSONPath("types"), node);
		}

		public static void outputRecipes()
		{
			Pipliz.JSON.JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

			foreach (Recipe recipe in Managers.RecipeManager.recipeList)
			{
				Pipliz.JSON.JSONNode recipenode = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

                recipenode.SetAs("fuelCost", recipe.FuelCost);
                recipenode.SetAs("playerCraftable", recipe.PlayerCraftable);
                recipenode.SetAs("type", recipe.Type);

                List<string> resultingTypes = new List<string>();

				Pipliz.JSON.JSONNode requirementArr = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Array);
                Pipliz.JSON.JSONNode resultArr = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Array);


				foreach (InventoryItem i in recipe.Requirements)
				{
					Pipliz.JSON.JSONNode reqItem = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

					reqItem.SetAs("type", ItemTypes.IndexLookup.GetName(i.Type));
					reqItem.SetAs("amount", i.Amount);

					requirementArr.AddToArray(reqItem);
				}

				foreach (InventoryItem i in recipe.Results)
				{
					Pipliz.JSON.JSONNode resItem = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

                    string typename = ItemTypes.IndexLookup.GetName(i.Type);
					resItem.SetAs("type", typename);
					resItem.SetAs("amount", i.Amount);

					requirementArr.AddToArray(resItem);

                    // flag an recipes that have more than 1 result (for the website)
                    if(resultingTypes.Count == 0) {
                        recipenode.SetAs("repeatRecipe", false);
					}
					else
					{
                        recipenode.SetAs("repeatRecipe", true);
                    }

                    resultingTypes.Add(typename);
				}

				recipenode.SetAs("requirements", requirementArr);
				recipenode.SetAs("results", resultArr);

				node.SetAs<Pipliz.JSON.JSONNode>(resultingTypes[0], recipenode);
			}

			Pipliz.JSON.JSON.Serialize(Utilities.GetDebugJSONPath("types"), node);
		}
    }
}
