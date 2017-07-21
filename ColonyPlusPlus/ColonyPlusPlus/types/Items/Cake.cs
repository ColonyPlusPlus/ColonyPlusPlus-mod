using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.types.items
{
    class Cake : classes.Type
    {
        public Cake(string name) : base(name)
        {
            this.NutritionalValue = 6.0f;
			this.CustomData = new CustomDataHelper("test", "somevalue").customDataNode;
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("baking",
                new List<InventoryItem> {
                    RecipeManager.Item("flour", 4),
                    RecipeManager.Item("egg", 2),
                    RecipeManager.Item("butter", 2),
                    RecipeManager.Item("sugar", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("cake", 1)
                },
                0.0f);
        }
    }
}
