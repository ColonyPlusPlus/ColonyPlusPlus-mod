using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class WaterBottle : ColonyAPI.Classes.Type
    {
        public WaterBottle(string name) : base(name, true)
        {
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 4)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("waterbottle", 2)
                },
                0.0f);

            RecipeManager.AddRecipe("well",
                new List<InventoryItem> {
                    RecipeManager.Item("bottle", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("waterbottle", 2)
                },
                0.0f);
        }
    }
}
