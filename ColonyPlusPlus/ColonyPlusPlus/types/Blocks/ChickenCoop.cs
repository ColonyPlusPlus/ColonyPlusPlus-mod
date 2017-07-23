using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.blocks
{
    class ChickenCoop : classes.Type
    {
        public ChickenCoop(string name) : base(name)
        {

            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";

            //this.Mesh = "ChickenCoop";
            this.SideAll = "planks";
            this.IsPlaceable = true;

            this.Register();
        }

        public override void AddRecipes()
        {
            /*RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtemperate", 1),
                    RecipeManager.Item("planks", 4),
                    RecipeManager.Item("straw", 3)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("chickencoop", 1)
                },
                0.0f);*/
        }
    }
}
