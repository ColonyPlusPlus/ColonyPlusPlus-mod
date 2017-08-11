using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Cheese : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Cheese() : base(true)
        {
            this.TypeName = "cheese";
            this.AllowCreative = true;
            ) : base()
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("butter", 2),
                    RecipeManager.Item("salt", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("cheese", 1)
                },
                0.0f, true);
        }
    }
}
