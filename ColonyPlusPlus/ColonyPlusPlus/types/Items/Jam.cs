using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Jam : classes.Type
    {
        public Jam(string name) : base(name)
        {
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
