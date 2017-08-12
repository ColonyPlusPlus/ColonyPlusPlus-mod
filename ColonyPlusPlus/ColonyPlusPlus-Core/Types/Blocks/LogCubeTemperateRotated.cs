using ColonyPlusPlusCore.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class LogCubeTemperateRotated : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTemperateRotated() : base(true)
        {
            this.TypeName = "logcubetemperaterotated";
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("logcubetemperaterotated",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "logcuberotated";


            this.RotatableXMinus = "logcubetemperaterotatedx";
            this.RotatableXPlus = "logcubetemperaterotatedx";
            this.RotatableZMinus = "logcubetemperaterotatedz";
            this.RotatableZPlus = "logcubetemperaterotatedz";
            this.IsAutoRotatable = true;
            this.IsPlaceable = true;
            
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logtemperate", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logcubetemperaterotated", 1)
                },
                false, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logcubetemperate", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logcubetemperaterotated", 1)
                });
        }
    }
}
