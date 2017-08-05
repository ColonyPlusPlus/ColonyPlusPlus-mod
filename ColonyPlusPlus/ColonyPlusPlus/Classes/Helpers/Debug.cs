using System;
using System.Collections;
using System.Collections.Generic;

namespace ColonyPlusPlus.Classes.Helpers
{
    public static class Debug
    {
		public static void outputTypes()
		{
			Pipliz.JSON.JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Array);

			foreach (string typename in Managers.TypeManager.AddedTypes)
			{
				Pipliz.JSON.JSONNode outputtype = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

				Pipliz.JSON.JSONNode itemJson = ItemTypes.GetTypesJSON.GetAs<Pipliz.JSON.JSONNode>(typename);

                //Utilities.WriteLog("Outputting JSON: " + typename);

                string icon = "";
                itemJson.TryGetAs<string>("icon", out icon);

				outputtype.SetAs("icon", icon);

                int maxstack = 0;
                itemJson.TryGetAs<int>("maxStackSize", out maxstack);
                          
                outputtype.SetAs("maxstack", maxstack);
				outputtype.SetAs("name", typename);

                bool newtype = false;
                itemJson.TryGetAs<bool>("newtype", out newtype);

                outputtype.SetAs("newtype", newtype);

                bool isPlaceable = false;
                itemJson.TryGetAs<bool>("isPlaceable", out isPlaceable);

                outputtype.SetAs("isplaceable", isPlaceable);

                bool isBaseBlock = false;
                itemJson.TryGetAs<bool>("isBaseBlock", out isBaseBlock);

                outputtype.SetAs("isbaseblock", isBaseBlock);

				node.AddToArray(outputtype);
			}

			Pipliz.JSON.JSON.Serialize(Utilities.GetDebugJSONPath("types"), node);
		}

		public static void outputRecipes()
		{
			Pipliz.JSON.JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Array);

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

					resultArr.AddToArray(resItem);

                    resultingTypes.Add(typename);
				}

				recipenode.SetAs("requirements", requirementArr);
				recipenode.SetAs("results", resultArr);
                recipenode.SetAs("mainresulttype", resultingTypes[0]);

				node.AddToArray(recipenode);
			}

			Pipliz.JSON.JSON.Serialize(Utilities.GetDebugJSONPath("recipes"), node);
		}
    }
}
