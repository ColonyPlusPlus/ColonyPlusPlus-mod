using ColonyPlusPlus.classes;
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

            this.Mesh = "ChickenCoop";
            this.SideAll = "planks";
            this.IsPlaceable = true;

            CustomDataItem[] customData = { new CustomDataItem("minerIsMineable", true), new CustomDataItem("minerMiningTime", true) };
            CustomDataHelper c = new CustomDataHelper(customData);
            this.CustomData = c.customDataNode;

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("feather",    2,  1.0f),
                new classes.ItemHelper.OnRemove("feather",    1,  0.55f),
                new classes.ItemHelper.OnRemove("egg",        1,  0.2f)
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
