using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Omlette : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Omlette() : base(true)
        {
            this.TypeName = "omlette";
            this.NutritionalValue = 1.0f;
            this.AllowCreative = true;
            ) : base()
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
