using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;
using ColonyPlusPlus.Classes;

namespace ColonyPlusPlus.Types.Items
{
    class Cake : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Cake() : base(true)
        {
            this.TypeName = "cake";
            this.NutritionalValue = 25.0f;
			this.CustomData = new CustomDataHelper("test", "somevalue").customDataNode;
            this.AllowCreative = true;
            ) : base()
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("flour", 4),
                    RecipeManager.Item("egg", 2),
                    RecipeManager.Item("butter", 2),
                    RecipeManager.Item("sugar", 2),
                    RecipeManager.Item("bottle", 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("cake", 1),
                    RecipeManager.Item("bottle", 1)
                },
                0.0f);
        }
    }
}
