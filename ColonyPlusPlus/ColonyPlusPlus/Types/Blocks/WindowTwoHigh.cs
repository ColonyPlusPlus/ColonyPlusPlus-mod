using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class WindowTwoHigh : ColonyAPI.Classes.Type
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

    class WindowTwoHighXMinus : ColonyAPI.Classes.Type
    {
        public WindowTwoHighXMinus(string name) : base(name)
        {
            this.ParentType = "windowtwohigh";

            this.Mesh = "windowtwohighx";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowTwoHighXPlus : ColonyAPI.Classes.Type
    {
        public WindowTwoHighXPlus(string name) : base(name)
        {
            this.ParentType = "windowtwohigh";

            this.Mesh = "windowtwohighx";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowTwoHighZMinus : ColonyAPI.Classes.Type
    {
        public WindowTwoHighZMinus(string name) : base(name)
        {
            this.ParentType = "windowtwohigh";

            this.Mesh = "windowtwohighz";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowTwoHighZPlus : ColonyAPI.Classes.Type
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
