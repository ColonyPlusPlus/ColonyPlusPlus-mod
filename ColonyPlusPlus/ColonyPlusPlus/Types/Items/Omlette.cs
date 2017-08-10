using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Omlette : ColonyAPI.Classes.Type
    {
        public Omlette(string name) : base(name, true)
        {
            this.NutritionalValue = 1.0f;
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
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
