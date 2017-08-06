using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class Anvil : Classes.Type
    {
        public Anvil(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.SideAll = "furnaceside";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.AllowPlayerCraft = true;
            this.Mesh = "anvil";
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("ironingot", 8)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("anvil", 1)
                },
                0.0f,true, true);
        }
    }
}
