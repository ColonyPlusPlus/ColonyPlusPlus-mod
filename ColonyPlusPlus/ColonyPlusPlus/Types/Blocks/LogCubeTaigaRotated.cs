using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTaigaRotated : Classes.Type
    {
        public LogCubeTaigaRotated(string name) : base(name, true)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("logcubetaigarotated",   1,  1.0f)
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
