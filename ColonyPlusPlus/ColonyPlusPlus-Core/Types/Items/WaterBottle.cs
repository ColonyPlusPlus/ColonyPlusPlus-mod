using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
{
    class WaterBottle : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WaterBottle() : base(true)
        {
            this.TypeName = "waterbottle";
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("goldcoin", 4)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("waterbottle", 2)
                });

            ColonyAPI.Managers.RecipeManager.AddRecipe("well",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("bottle", 2)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("waterbottle", 2)
                });
        }
    }
}
