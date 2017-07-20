using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Sugar : classes.Type
    {
        public Sugar(string name) : base(name)
        {
            this.Register();

            
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("grinding",
                new List<InventoryItem> {
                    RecipeManager.Item("sugarcaneitem", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("sugar", 1)
                },
                0.0f);

            
        }
    }
}
