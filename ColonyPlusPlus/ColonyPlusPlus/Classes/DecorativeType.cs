using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes
{
    class DecorativeTypeBlock : Classes.Type
    {
        private string BaseMaterial;
        private string CraftingType;
        private List<InventoryItem> CraftingRequiredItem;

        public DecorativeTypeBlock(string basename, string basematerial, List<InventoryItem> craftingingredients, string craftingtype) : base(basename, true)
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
            RecipeManager.AddRecipe(this.CraftingType,
                CraftingRequiredItem,
                new List<InventoryItem> {
                    RecipeManager.Item(this.TypeName, 1)
                },
                0.0f);
        }
    }

    // slope
    class DecorativeTypeBase : Classes.Type
    {
        private string BaseMaterial;
        private string CraftingType;
        private List<InventoryItem> CraftingRequiredItem;
        private string Shape;

        public DecorativeTypeBase(string basename, string shape, string basematerial, List<InventoryItem> craftingingredients, string craftingtype) : base(String.Format("{0}{1}",basename,shape), true)
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
            RecipeManager.AddRecipe(this.CraftingType,
                CraftingRequiredItem,
                new List<InventoryItem> {
                    RecipeManager.Item(this.TypeName, 1)
                },
                0.0f);
        }
    }
    class DecorativeTypeXMinus : Classes.Type
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
    class DecorativeTypeXPlus : Classes.Type
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
    class DecorativeTypeZMinus : Classes.Type
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
    class DecorativeTypeZPlus : Classes.Type
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
