using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Bottle : Classes.Type
    {
        public Bottle(string name) : base(name, true)
        {
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bottle", 2)
                },
                0.0f);

            RecipeManager.AddRecipe("smelting",
                new List<InventoryItem> {
                    RecipeManager.Item("sand", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bottle", 2)
                },
                0.0f);
        }
    }
}
