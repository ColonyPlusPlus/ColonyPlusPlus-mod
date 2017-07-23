using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.classes
{
    class DecorativeTypeBlock : classes.Type
    {
        private string BaseMaterial;
        private string CraftingType;

        public DecorativeTypeBlock(string basename, string basematerial, string craftingtype) : base(basename)
        {
            // decorative block specific
            this.BaseMaterial = basematerial;
            this.CraftingType = craftingtype;

            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";

            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Register();
        }
        public override void AddRecipes()
        {
            RecipeManager.AddRecipe(this.CraftingType,
                new List<InventoryItem> {
                    RecipeManager.Item(this.BaseMaterial, 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item(this.TypeName, 1)
                },
                0.0f);
        }
    }

    // slope
    class DecorativeTypeBase : classes.Type
    {
        private string BaseMaterial;
        private string CraftingType;
        private string CraftingRequiredItem;
        private string Shape;

        public DecorativeTypeBase(string basename, string shape, string basematerial, string craftingrequireditem, string craftingtype) : base(String.Format("{0}{1}",basename,shape))
        {
            // decorative block specific
            this.BaseMaterial = basematerial;
            this.CraftingType = craftingtype;
            this.CraftingRequiredItem = craftingrequireditem;
            this.Shape = shape;

            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.RotatableXMinus = basename + shape + "x-";
            this.RotatableXPlus = basename + shape + "x+";
            this.RotatableZMinus = basename + shape + "z-";
            this.RotatableZPlus = basename + shape + "z+";
            this.Icon = basename + shape;

            this.SideAll = basematerial;
            
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.IsAutoRotatable = true;
            this.Register();
        }
        public override void AddRecipes()
        {
            RecipeManager.AddRecipe(this.CraftingType,
                new List<InventoryItem> {
                    RecipeManager.Item(this.CraftingRequiredItem, 1)
                },
                new List<InventoryItem> {
                    RecipeManager.Item(this.TypeName, 1)
                },
                0.0f);
        }
    }
    class DecorativeTypeXMinus : classes.Type
    {
        public DecorativeTypeXMinus(string name, string shape, string texture) : base(name + shape + "x-")
        {
            this.ParentType = name + shape;
            this.SideAll = texture;
            this.Mesh = shape + "x-";
            this.Icon = name + shape;
            this.Register();
        }
    }
    class DecorativeTypeXPlus : classes.Type
    {
        public DecorativeTypeXPlus(string name, string shape, string texture) : base(name + shape + "x+")
        {
            this.ParentType = name + shape;
            this.SideAll = texture;
            this.Mesh = shape + "x+";
            this.Icon = name + shape;
            this.Register();
        }
    }
    class DecorativeTypeZMinus : classes.Type
    {
        public DecorativeTypeZMinus(string name, string shape, string texture) : base(name + shape + "z-")
        {
            this.ParentType = name + shape;
            this.SideAll = texture;
            this.Mesh = shape + "z-";
            this.Icon = name + shape;
            this.Register();
        }
    }
    class DecorativeTypeZPlus : classes.Type
    {
        public DecorativeTypeZPlus(string name, string shape, string texture) : base(name + shape + "z+")
        {
            this.ParentType = name + shape;
            this.SideAll = texture;
            this.Mesh = shape + "z+";
            this.Icon = name + shape;
            this.Register();
        }
    }




}
