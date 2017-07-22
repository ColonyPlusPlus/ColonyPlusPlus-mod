using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class StoneBricks : classes.Type
    {
        public StoneBricks(string name) : base(name)
        {
            this.DestructionTime = 600;
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.IsPlaceable = true;
            this.Register();
        }

        public override void AddRecipes()
        {

            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("stoneblock", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 1)
                },
                0.0f);
        }

    }
}
