using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.JobBlocks
{
    class Sawmill : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Sawmill() : base()
        {
            this.TypeName = "sawmill";
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.SideAll = "planks";
            this.SideYPlus = "carpentrytable";
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
                    RecipeManager.Item("planks", 12),
                    RecipeManager.Item("ironingot", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("sawmill", 1)
                },
                0.0f, true, true);
        }
    }
}
