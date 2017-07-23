﻿using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class LogCubeTaiga : classes.Type
    {
        public LogCubeTaiga(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("logcubetaiga",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;

            this.ParentType = "logcube";

            this.SideAll = "cpplogtaiga";
            this.SideYPlus = "cpplogtaigatop";
            this.SideYMinus = "cpplogtaigatop";
            this.AllowCreative = true;
            this.IsPlaceable = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtaiga", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("logcubetaiga", 1)
                },
                0.0f);
        }
    }
}