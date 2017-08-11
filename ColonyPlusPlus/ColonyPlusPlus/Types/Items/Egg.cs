using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Egg : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Egg() : base(true)
        {
            this.TypeName = "egg";
            this.AllowCreative = true;
            ) : base()
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("shopping",
                new List<InventoryItem> {
                    RecipeManager.Item("goldcoin", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("egg", 2)
                },
                0.0f);
        }
    }
}
