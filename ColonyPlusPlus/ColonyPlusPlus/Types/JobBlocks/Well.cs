using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class Well : Classes.Type
    {
        public Well(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.SideAll = "stonebricks";
            this.SideYPlus = "welltop";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.AllowPlayerCraft = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("stonebricks", 12),
                    RecipeManager.Item("planks", 6)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("well", 1)
                },
                0.0f, true, true);
        }
    }
}
