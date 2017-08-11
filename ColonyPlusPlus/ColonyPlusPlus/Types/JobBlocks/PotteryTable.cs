using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
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
            ) : base()
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtemperate", 1),
                    RecipeManager.Item("planks", 4),
                    RecipeManager.Item("stonebricks", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("potterytable", 1)
                },
                0.0f,true, true);
        }
    }
}
