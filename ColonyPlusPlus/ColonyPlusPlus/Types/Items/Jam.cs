using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Jam : Classes.Type
    {
        public Jam(string name) : base(name, true)
        {
            this.AllowCreative = true;
            this.Register();

        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("berry", 1),
                    RecipeManager.Item("sugar", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("jam", 1)
                },
                0.0f);
        }
    }
}
