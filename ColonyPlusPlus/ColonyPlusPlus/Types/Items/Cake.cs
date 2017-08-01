using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.Classes.Managers;
using ColonyPlusPlus.Classes;

namespace ColonyPlusPlus.Types.Items
{
    class Cake : Classes.Type
    {
        public Cake(string name) : base(name)
        {
            this.NutritionalValue = 25.0f;
			this.CustomData = new CustomDataHelper("test", "somevalue").customDataNode;
            this.AllowCreative = true;
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
