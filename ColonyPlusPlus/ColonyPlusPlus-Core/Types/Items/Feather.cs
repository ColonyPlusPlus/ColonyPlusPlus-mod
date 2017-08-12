using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
{
    class Feather : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Feather() : base(true)
        {
            this.TypeName = "feather";
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
                    ColonyAPI.Managers.RecipeManager.Item("feather", 1)
                });

            ColonyAPI.Managers.RecipeManager.AddRecipe("chickenplucker",
               new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("straw", 1),
                    ColonyAPI.Managers.RecipeManager.Item("wheatstage1", 1)
               },
               new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("feather", 2)
               }, true);
        }
    }
}
