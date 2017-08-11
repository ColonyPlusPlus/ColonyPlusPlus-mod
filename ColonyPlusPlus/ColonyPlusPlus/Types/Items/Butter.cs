using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Butter : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Butter() : base(true)
        {
            this.TypeName = "butter";
            this.AllowCreative = true;
            ) : base()
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("milk", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("butter", 1)
                },
                0.0f, true);
        }
    }
}
