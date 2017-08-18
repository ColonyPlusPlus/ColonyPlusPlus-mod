using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
{
    class Omlette : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Omlette() : base(true)
        {
            this.TypeName = "omlette";
            this.NutritionalValue = 1.0f;
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddFueledRecipe("baking",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("egg", 2)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("omlette", 1)
                });
        }
    }
}
