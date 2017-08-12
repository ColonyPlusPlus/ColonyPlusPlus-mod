using ColonyPlusPlusCore.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.JobBlocks
{
    class Anvil : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Anvil() : base()
        {
            this.TypeName = "anvil";
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
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("ironingot", 8)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("anvil", 1)
                }, true, true);
        }
    }
}
