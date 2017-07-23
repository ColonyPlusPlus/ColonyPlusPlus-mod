using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Butter : classes.Type
    {
        public Butter(string name) : base(name)
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
                    RecipeManager.Item("butter", 1)
                },
                0.0f);
        }
    }
}
