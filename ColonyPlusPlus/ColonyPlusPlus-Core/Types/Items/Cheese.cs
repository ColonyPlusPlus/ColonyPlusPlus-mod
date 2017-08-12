using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
{
    class Cheese : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Cheese() : base(true)
        {
            this.TypeName = "cheese";
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("butter", 2),
                    ColonyAPI.Managers.RecipeManager.Item("salt", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("cheese", 1)
                }, true);
        }
    }
}
