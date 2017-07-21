using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Cake : classes.Type
    {
        public Cake(string name) : base(name)
        {
            this.NutritionalValue = 3.0f;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("flour", 2),
                    RecipeManager.Item("egg", 1),
                    RecipeManager.Item("butter", 1),
                    RecipeManager.Item("sugar", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("cake", 1)
                },
                0.0f);
        }
    }
}
