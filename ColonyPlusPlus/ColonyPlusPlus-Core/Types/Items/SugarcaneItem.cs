using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
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
            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 2)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("sugarcaneitem", 2)
                });
        }
    }
}
