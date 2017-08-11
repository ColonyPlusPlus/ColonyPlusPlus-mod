using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Salt : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Salt() : base(true)
        {
            this.TypeName = "salt";
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("salt", 1)
                },
                0.0f);
        }
    }
}
