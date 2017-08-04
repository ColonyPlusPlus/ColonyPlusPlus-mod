using ColonyPlusPlus.Classes;
using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class ChickenCoop : Classes.Type
    {
        public ChickenCoop(string name) : base(name, true)
        {

            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";

            this.Mesh = "ChickenCoop";
            this.SideAll = "planks";
            this.IsPlaceable = true;
            this.AllowCreative = true;

            CustomDataItem[] customData = { new CustomDataItem("minerIsMineable", true), new CustomDataItem("minerMiningTime", 8.0f) };
            CustomDataHelper c = new CustomDataHelper(customData);
            this.CustomData = c.customDataNode;

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("feather",    2,  1.0f)
            };
            this.OnRemove = onRemoveNode;

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
                    RecipeManager.Item("chickencoop", 1)
                },
                0.0f);
        }
    }
}
