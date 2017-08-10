using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Sugar : ColonyAPI.Classes.Type
    {
        public Sugar(string name) : base(name, true)
        {
            this.AllowCreative = true;
            this.Register();

            
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("grinding",
                new List<InventoryItem> {
                    RecipeManager.Item("sugarcaneitem", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("sugar", 1)
                },
                0.0f);

            
        }
    }
}
