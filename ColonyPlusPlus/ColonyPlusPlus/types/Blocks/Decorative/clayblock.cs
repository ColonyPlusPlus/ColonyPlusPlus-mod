using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks.Decorative
{
    class clayblock : classes.Type
    {
        public clayblock(string name) : base(name)
        {
            this.DestructionTime = 600;
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.IsPlaceable = true;
            this.Register();
        }

        public override void AddRecipes()
        {

            RecipeManager.AddRecipe("smelting",
                new List<InventoryItem> {
                    RecipeManager.Item("clay", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item(this.TypeName, 1)
                },
                0.0f);
        }

    }
}
