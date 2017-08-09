using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class WindowTwoHigh : Classes.Type
    {
        public WindowTwoHigh(string name) : base (name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.Mesh = "windowtwohigh";
            this.SideAll = "planks";
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.IsAutoRotatable = true;
            this.RotatableXMinus = "windowtwohighx-";
            this.RotatableXPlus = "windowtwohighx+";
            this.RotatableZMinus = "windowtwohighz-";
            this.RotatableZPlus = "windowtwohighz+";
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 4)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("windowtwohigh", 1)
                },
                0.0f, false, true);
        }
    }

    class WindowTwoHighXMinus : Classes.Type
    {
        public WindowTwoHighXMinus(string name) : base(name)
        {
            this.ParentType = "windowtwohigh";

            this.Mesh = "windowtwohighx";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowTwoHighXPlus : Classes.Type
    {
        public WindowTwoHighXPlus(string name) : base(name)
        {
            this.ParentType = "windowtwohigh";

            this.Mesh = "windowtwohighx";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowTwoHighZMinus : Classes.Type
    {
        public WindowTwoHighZMinus(string name) : base(name)
        {
            this.ParentType = "windowtwohigh";

            this.Mesh = "windowtwohighz";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowTwoHighZPlus : Classes.Type
    {
        public WindowTwoHighZPlus(string name) : base(name)
        {
            this.ParentType = "windowtwohigh";

            this.Mesh = "windowtwohighz";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
}
