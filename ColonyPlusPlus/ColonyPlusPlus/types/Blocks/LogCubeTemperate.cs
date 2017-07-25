using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class LogCubeTemperate : classes.Type
    {
        public LogCubeTemperate(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("logcubetemperate",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "logcube";

            this.SideAll = "cpplogtemperate";
            this.SideYPlus = "cpplogtemperatetop";
            this.SideYMinus = "cpplogtemperatetop";

            this.AllowCreative = true;
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
                    RecipeManager.Item("logcubetemperate", 1)
                },
                0.0f);

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
