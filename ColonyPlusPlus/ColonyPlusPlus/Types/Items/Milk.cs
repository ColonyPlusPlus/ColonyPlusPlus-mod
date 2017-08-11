using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Milk : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Milk() : base(true)
        {
            this.TypeName = "milk";
            this.AllowCreative = true;
            ) : base()
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("milk", 2)
                },
                0.0f);
        }
    }
}
