using ColonyPlusPlusCore.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.JobBlocks
{
    class PotteryTable : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public PotteryTable() : base()
        {
            this.TypeName = "potterytable";
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.SideAll = "stonebricks";
            this.Mesh = "potterywheel";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.AllowPlayerCraft = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logtemperate", 1),
                    ColonyAPI.Managers.RecipeManager.Item("planks", 4),
                    ColonyAPI.Managers.RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("potterytable", 1)
                },true, true);
        }
    }
}
