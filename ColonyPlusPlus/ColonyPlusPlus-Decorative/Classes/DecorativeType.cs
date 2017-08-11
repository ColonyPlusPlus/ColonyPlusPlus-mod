using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusDecorative.Classes
{
    class DecorativeTypeBlock : ColonyAPI.Classes.Type
    {
        private string BaseMaterial;
        private string CraftingType;
        private List<KeyValuePair<string, int>> CraftingRequiredItem;

        public DecorativeTypeBlock(string basename, string basematerial, List<KeyValuePair<string, int>> craftingingredients, string craftingtype) : base(basename, true)
        {
            // decorative block specific
            this.BaseMaterial = basematerial;
            this.CraftingType = craftingtype;
            this.CraftingRequiredItem = craftingingredients;
            this.AllowCreative = true;

            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";

            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Register();
        }
        public override void AddRecipes()
        {
            List<InventoryItem> l = new List<InventoryItem>();
            foreach (KeyValuePair<string, int> kvp in CraftingRequiredItem)
            {
                l.Add(ColonyAPI.Managers.RecipeManager.Item( kvp.Key, kvp.Value));
            }

            RecipeManager.AddRecipe(this.CraftingType,
                l,
                new List<InventoryItem> {
                    RecipeManager.Item(this.TypeName, 1)
                },
                0.0f);
        }
    }

    // slope
    class DecorativeTypeBase : ColonyAPI.Classes.Type
    {
        private string BaseMaterial;
        private string CraftingType;
        private List<KeyValuePair<string, int>> CraftingRequiredItem;
        private string Shape;

        public DecorativeTypeBase(string basename, string shape, string basematerial, List<KeyValuePair<string, int>> craftingingredients, string craftingtype) : base(String.Format("{0}{1}",basename,shape), true)
        {
            // decorative block specific
            this.BaseMaterial = basematerial;
            this.CraftingType = craftingtype;
            this.CraftingRequiredItem = craftingingredients;
            this.Shape = shape;

            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.RotatableXMinus = basename + shape + "x-";
            this.RotatableXPlus = basename + shape + "x+";
            this.RotatableZMinus = basename + shape + "z-";
            this.RotatableZPlus = basename + shape + "z+";
            this.Icon = basename + shape;

            this.SideAll = basematerial;

            this.MaxStackSize = 1000;
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.IsAutoRotatable = true;
            this.Register();
        }
        public override void AddRecipes()
        {
            List<InventoryItem> l = new List<InventoryItem>();
            foreach (KeyValuePair<string, int> kvp in CraftingRequiredItem)
            {
                l.Add(RecipeManager.Item(kvp.Key, kvp.Value));
            }

            RecipeManager.AddRecipe(this.CraftingType,
                l,
                new List<InventoryItem> {
                    RecipeManager.Item(this.TypeName, 1)
                },
                0.0f);
        }
    }
    class DecorativeTypeXMinus : ColonyAPI.Classes.Type
    {
        public DecorativeTypeXMinus(string name, string shape, string texture) : base(name + shape + "x-", true)
        {
            this.ParentType = name + shape;
            this.SideAll = texture;
            this.Mesh = shape + "x-";
            this.Icon = name + shape;
            this.IsBaseBlock = false;
            this.Register();
        }
    }
    class DecorativeTypeXPlus : ColonyAPI.Classes.Type
    {
        public DecorativeTypeXPlus(string name, string shape, string texture) : base(name + shape + "x+", true)
        {
            this.ParentType = name + shape;
            this.SideAll = texture;
            this.Mesh = shape + "x+";
            this.Icon = name + shape;
            this.IsBaseBlock = false;
            this.Register();
        }
    }
    class DecorativeTypeZMinus : ColonyAPI.Classes.Type
    {
        public DecorativeTypeZMinus(string name, string shape, string texture) : base(name + shape + "z-", true)
        {
            this.ParentType = name + shape;
            this.SideAll = texture;
            this.Mesh = shape + "z-";
            this.Icon = name + shape;
            this.IsBaseBlock = false;
            this.Register();
        }
    }
    class DecorativeTypeZPlus : ColonyAPI.Classes.Type
    {
        public DecorativeTypeZPlus(string name, string shape, string texture) : base(name + shape + "z+", true)
        {
            this.ParentType = name + shape;
            this.SideAll = texture;
            this.Mesh = shape + "z+";
            this.Icon = name + shape;
            this.IsBaseBlock = false;
            this.Register();
        }
    }




}
