using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Types.Items
{
    class Feather : Classes.Type
    {
        public Feather(string name) : base(name, true)
        {
            this.AllowCreative = true;
            this.Register();
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
