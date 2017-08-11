using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Feather : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Feather() : base(true)
        {
            this.TypeName = "feather";
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
                    RecipeManager.Item("feather", 1)
                },
                0.0f);

            RecipeManager.AddRecipe("chickenplucker",
               new List<InventoryItem> {
                    RecipeManager.Item("straw", 1),
                    RecipeManager.Item("wheatstage1", 1)
               },
               new List<InventoryItem> {
                    RecipeManager.Item("feather", 2)
               },
               0.0f, true);
        }
    }
}
