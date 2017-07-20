using System.Collections.Generic;

namespace ColonyPlusPlus.classes.Managers
{
    class RecipeManager
    {
        public static void registerbaking()
        {

            Recipe.AddRecipe("baking",
                new List<InventoryItem> {
                    Recipe.Item("berry", 2),
                    Recipe.Item("bread", 1)
                },
                new List<InventoryItem> {
                    Recipe.Item("jambread", 1)
                },
                0.0f);

           
        }

        public static void registercrafting()
        {
        }

        public static void registergrinding()
        {
        }

        public static void registerminting()
        {
        }

        public static void registershopping()
        {
        }

        public static void registersmeling()
        {
        }
    }
}
