using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlusCore.Managers;


namespace ColonyPlusPlusCore.Types.Items
{
    class Cake : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Cake() : base(true)
        {
            this.TypeName = "cake";
            this.NutritionalValue = 25.0f;
			this.CustomData = new ColonyAPI.Classes.CustomDataNode("test", "somevalue").customDataNode;
            this.AllowCreative = true;
            this.Register();
        }

        public override void AddRecipes()
        {
            ColonyAPI.Managers.RecipeManager.AddFueledRecipe("baking",
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("flour", 4),
                    ColonyAPI.Managers.RecipeManager.Item("egg", 2),
                    ColonyAPI.Managers.RecipeManager.Item("butter", 2),
                    ColonyAPI.Managers.RecipeManager.Item("sugar", 2),
                    ColonyAPI.Managers.RecipeManager.Item("bottle", 1)
                },
                new List<InventoryItem> {
                    ColonyAPI.Managers.RecipeManager.Item("cake", 1),
                    ColonyAPI.Managers.RecipeManager.Item("bottle", 1)
                });
        }
    }
}
