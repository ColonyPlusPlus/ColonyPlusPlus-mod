using ColonyPlusPlusCore.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class LogCubeTemperate : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTemperate() : base(true)
        {
            this.TypeName = "logcubetemperate";
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("logcubetemperate",   1,  1.0f)
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
            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logtemperate", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logcubetemperate", 1)
                }, false, true);

            ColonyAPI.Managers.RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logcubetemperaterotated", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("logcubetemperate", 1)
                }
                );
        }
    }
}
