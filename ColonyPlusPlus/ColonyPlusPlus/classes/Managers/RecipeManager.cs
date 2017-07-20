using System.Collections.Generic;

namespace ColonyPlusPlus.classes.Managers
{
    class RecipeManager
    {
        public static void registerbaking()
        {
            RecipeFueled i;

            List<InventoryItem> reqs = new List<InventoryItem>();
         
            reqs.Add(new InventoryItem(ItemTypes.IndexLookup.GetIndex("berry"), 2));
            reqs.Add(new InventoryItem(ItemTypes.IndexLookup.GetIndex("bread"), 1));

            List<InventoryItem> result = new List<InventoryItem>();
            result.Add(new InventoryItem(ItemTypes.IndexLookup.GetIndex("jambread"), 1));


            i = new RecipeFueled(0.0f, reqs, result);

            RecipeBaking.AllRecipes.Add(i);
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
