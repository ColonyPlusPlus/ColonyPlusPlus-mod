using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class SugarcaneItem : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public SugarcaneItem() : base(true)
        {
            this.TypeName = "sugarcaneitem";
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
                    RecipeManager.Item("sugarcaneitem", 2)
                },
                0.0f);
        }
    }
}
