using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
{
    class Jam : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Jam() : base(true)
        {

            this.TypeName = "jam";
            this.AllowCreative = true;
            this.Register();

        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("berry", 1),
                    ColonyAPI.Managers.RecipeManager.Item("sugar", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("jam", 1)
                });
        }
    }
}
