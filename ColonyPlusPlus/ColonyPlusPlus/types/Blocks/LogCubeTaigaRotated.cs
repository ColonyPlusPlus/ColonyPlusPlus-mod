using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class LogCubeTaigaRotated : classes.Type
    {
        public LogCubeTaigaRotated(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("logcubetaigarotated",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "logcuberotated";


            this.RotatableXMinus = "logcubetaigarotatedx";
            this.RotatableXPlus = "logcubetaigarotatedx";
            this.RotatableZMinus = "logcubetaigarotatedz";
            this.RotatableZPlus = "logcubetaigarotatedz";
            this.IsAutoRotatable = true;
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
                    RecipeManager.Item("logcubetaigarotated", 1)
                },
                0.0f);
        }
    }
}
