using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class Sawmill : Classes.Type
    {
        public Sawmill(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.SideAll = "planks";
            this.SideYPlus = "workbenchtop";
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
                    RecipeManager.Item("logtemperate", 1),
                    RecipeManager.Item("planks", 4),
                    RecipeManager.Item("straw", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("sawmill", 1)
                },
                0.0f, true, true);
        }
    }
}
