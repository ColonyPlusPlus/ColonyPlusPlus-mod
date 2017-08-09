using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class Window : Classes.Type
    {
        public Window(string name) : base (name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.Mesh = "window";
            this.SideAll = "planks";
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.IsAutoRotatable = true;
            this.RotatableXMinus = "windowx-";
            this.RotatableXPlus = "windowx+";
            this.RotatableZMinus = "windowz-";
            this.RotatableZPlus = "windowz+";
            this.Register();
        }

        public override void AddRecipes()
        {
            RecipeManager.AddRecipe("crafting",
                new List<InventoryItem> {
                    RecipeManager.Item("planks", 2)
                },
                new List<InventoryItem> {
                    RecipeManager.Item("window", 1)
                },
                0.0f, false, true);
        }
    }

    class WindowXMinus : Classes.Type
    {
        public WindowXMinus(string name) : base(name)
        {
            this.ParentType = "window";

            this.Mesh = "windowx";
            this.IsBaseBlock = false;
            
            this.Register();
        }
    }
    class WindowXPlus : Classes.Type
    {
        public WindowXPlus(string name) : base(name)
        {
            this.ParentType = "window";

            this.Mesh = "windowx";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowZMinus : Classes.Type
    {
        public WindowZMinus(string name) : base(name)
        {
            this.ParentType = "window";

            this.Mesh = "windowz";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowZPlus : Classes.Type
    {
        public WindowZPlus(string name) : base(name)
        {
            this.ParentType = "window";

            this.Mesh = "windowz";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
}
