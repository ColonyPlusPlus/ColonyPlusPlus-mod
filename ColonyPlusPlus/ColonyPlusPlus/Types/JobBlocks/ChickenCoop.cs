using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.JobBlocks
{
    class ChickenCoop : Classes.Type
    {
        public ChickenCoop(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.Mesh = "ChickenCoop";
            this.SideAll = "planks";
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.NPCLimit = 0;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 8),
                    RecipeManager.Item("straw", 9)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("chickencoop", 1)
                },
                0.0f, true, true);
        }
    }
}
