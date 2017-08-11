using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
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
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("berry", 1),
                    RecipeManager.Item("sugar", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("jam", 1)
                },
                0.0f);
        }
    }
}
