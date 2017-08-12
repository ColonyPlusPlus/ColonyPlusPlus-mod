using ColonyPlusPlusCore.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class LogCubeTaigaRotated : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTaigaRotated() : base(true)
        {
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("logcubetaigarotated",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "logcuberotated";


            this.TypeName = "logcubetaigarotated";
            this.RotatableXMinus = "logcubetaigarotatedx";
            this.RotatableXPlus = "logcubetaigarotatedx";
            this.RotatableZMinus = "logcubetaigarotatedz";
            this.RotatableZPlus = "logcubetaigarotatedz";
            this.IsAutoRotatable = true;
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
                    ColonyAPI.Managers.RecipeManager.Item("logcubetaigarotated", 1)
                },
                false, true);
        }
    }
}
