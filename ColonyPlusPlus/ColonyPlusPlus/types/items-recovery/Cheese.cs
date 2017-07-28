using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Cheese : Classes.Type
    {
        public Cheese(string name) : base(name)
        {
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("milk", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("cheese", 1)
                },
                0.0f);
        }
    }
}
