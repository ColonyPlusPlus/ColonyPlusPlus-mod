using ColonyPlusPlusCore.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class LogCubeTaiga : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTaiga() : base(true)
        {
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("logcubetaiga",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;

            this.TypeName = "logcubetaiga";
            this.ParentType = "logcube";

            this.SideAll = "cpplogtaiga";
            this.SideYPlus = "cpplogtaigatop";
            this.SideYMinus = "cpplogtaigatop";
            this.AllowCreative = true;
            this.IsPlaceable = true;
            
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logtaiga", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logcubetaiga", 1)
                },false, true);
        }
    }
}
