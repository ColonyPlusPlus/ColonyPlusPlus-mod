using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Cheese : classes.Type
    {
        public Cheese(string name) : base(name)
        {
            this.Register();

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
