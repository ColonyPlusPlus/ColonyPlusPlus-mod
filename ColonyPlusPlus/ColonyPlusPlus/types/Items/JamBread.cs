using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class JamBread : classes.Type
    {
        public JamBread(string name) : base(name)
        {
            this.NutritionalValue = 1.0f;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("berry", 2),
                    RecipeManager.Item("bread", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("jambread", 1)
                },
                0.0f);
        }
    }
}
