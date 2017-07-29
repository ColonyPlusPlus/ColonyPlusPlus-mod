using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Milk : Classes.Type
    {
        public Milk(string name) : base(name)
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
                    RecipeManager.Item("milk", 1)
                },
                0.0f);
        }
    }
}
