using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
{
    class JamBread : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public JamBread() : base(true)
        {
            this.TypeName = "jambread";
            this.NutritionalValue = 4.5f;
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("jam", 1),
                    ColonyAPI.Managers.RecipeManager.Item("bread", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("jambread", 1)
                });
        }
    }
}
