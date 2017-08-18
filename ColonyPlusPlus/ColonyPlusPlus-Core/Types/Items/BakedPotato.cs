using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;


namespace ColonyPlusPlusCore.Types.Items
{
    class BakedPotato : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public BakedPotato() : base(true)
        {
            this.TypeName = "bakedpotato";
            this.NutritionalValue = 1.0f;
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            
            ColonyAPI.Managers.RecipeManager.AddFueledRecipe("baking",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("potatostage1", 2),
                    ColonyAPI.Managers.RecipeManager.Item("cheese", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("bakedpotato", 1)
                });
        }
    }
}
