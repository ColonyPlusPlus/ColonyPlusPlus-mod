using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    public static class Recipe
    {


        public static bool AddRecipe(string type, List<InventoryItem> reqs, List<InventoryItem> result, float fuelAmount = 0.0f)
        {
            switch (type.ToLower())
            {
                case "crafting":


                    break;
                case "smelting":


                    break;
                case "minting":


                    break;
                case "grinding":


                    break;
                case "shopping":


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
