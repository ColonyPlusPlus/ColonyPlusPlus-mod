using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;

namespace ColonyPlusPlusCore.Types.Items
{
    class Sugar : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Sugar() : base(true)
        {
            this.TypeName = "sugar";
            this.AllowCreative = true;
            this.Register();

            
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("grinding",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("sugarcaneitem", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("sugar", 1)
                });

            
        }
    }
}
