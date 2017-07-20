using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Omlette : classes.Type
    {
        public Omlette(string name) : base(name)
        {
            this.NutritionalValue = 1.0f;
            this.Register();

            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("egg", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("omlette", 1)
                },
                0.0f);
        }
    }
}
