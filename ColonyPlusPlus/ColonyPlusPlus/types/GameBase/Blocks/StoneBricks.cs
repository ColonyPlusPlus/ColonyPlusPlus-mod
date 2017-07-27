using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class StoneBricks : Classes.Type
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
