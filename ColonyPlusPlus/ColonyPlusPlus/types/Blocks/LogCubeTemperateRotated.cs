using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class LogCubeTemperateRotated : classes.Type
    {
        public LogCubeTemperateRotated(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("logcubetemperaterotated",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "logcuberotated";


            this.RotatableXMinus = "logcubetemperaterotatedx";
            this.RotatableXPlus = "logcubetemperaterotatedx";
            this.RotatableZMinus = "logcubetemperaterotatedz";
            this.RotatableZPlus = "logcubetemperaterotatedz";
            this.IsAutoRotatable = true;
            this.IsPlaceable = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("logtemperate", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("logcubetemperaterotated", 1)
                },
                0.0f);
        }
    }
}
