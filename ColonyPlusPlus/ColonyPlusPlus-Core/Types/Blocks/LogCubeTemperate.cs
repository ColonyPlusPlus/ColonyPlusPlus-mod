﻿using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTemperate : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTemperate() : base(true)
        {
            this.TypeName = "logcubetemperate";
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("logcubetemperate",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "logcube";

            this.SideAll = "cpplogtemperate";
            this.SideYPlus = "cpplogtemperatetop";
            this.SideYMinus = "cpplogtemperatetop";

            this.AllowCreative = true;
            this.IsPlaceable = true;
            
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtemperate", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("logcubetemperate", 1)
                },
                0.0f, false, true);

            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logcubetemperaterotated", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("logcubetemperate", 1)
                },
                0.0f);
        }
    }
}