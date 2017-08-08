using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class WindowTwoHigh : Classes.Type
    {
        public WindowTwoHigh(string name) : base (name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.Mesh = "windowtwohigh";
            this.SideAll = "planks";
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("window", 1)
                },
                0.0f, false, true);
        }
    }
}
