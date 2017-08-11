using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class Window : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Window() : base ()
        {
            this.TypeName = "window";
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

    class WindowXMinus : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowXMinus() : base()
        {
            this.TypeName = "windowx-";
            this.ParentType = "window";

            this.SideAll = "planks";
            this.Mesh = "windowx";
            this.IsBaseBlock = false;
            
            this.Register();
        }
    }
    class WindowXPlus : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowXPlus() : base()
        {
            this.TypeName = "windowx+";
            this.ParentType = "window";
            this.SideAll = "planks";

            this.Mesh = "windowx";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowZMinus : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowZMinus() : base()
        {
            this.TypeName = "windowz-";
            this.ParentType = "window";
            this.SideAll = "planks";

            this.Mesh = "windowz";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
    class WindowZPlus : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowZPlus() : base()
        {
            this.TypeName = "windowz+";
            this.ParentType = "window";
            this.SideAll = "planks";

            this.Mesh = "windowz";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
}
