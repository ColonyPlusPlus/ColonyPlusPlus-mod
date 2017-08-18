using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
{
    class Bottle : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Bottle() : base(true)
        {
            this.TypeName = "bottle";
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
                    ColonyAPI.Managers.RecipeManager.Item("bottle", 2)
                });

            ColonyAPI.Managers.RecipeManager.AddFueledRecipe("smelting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("sand", 2)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("bottle", 2)
                });
        }
    }
}
