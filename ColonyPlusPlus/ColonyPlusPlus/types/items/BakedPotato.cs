using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class BakedPotato : classes.Type
    {
        public BakedPotato(string name) : base(name)
        {
            this.NutritionalValue = 1.0f;
            this.Register();

            
        }

        public override void AddRecipes()
        {
            
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("potato", 2),
                    RecipeManager.Item("cheese", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bakedpotato", 1)
                },
                0.0f);
        }
    }
}
