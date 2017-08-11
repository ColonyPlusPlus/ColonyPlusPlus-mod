using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Bottle : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Bottle() : base(true)
        {
            this.TypeName = "bottle";
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
                    RecipeManager.Item("bottle", 2)
                },
                0.0f);

            RecipeManager.AddRecipe("smelting",
                new List<InventoryItem> {
                    RecipeManager.Item("sand", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("bottle", 2)
                },
                0.0f);
        }
    }
}
