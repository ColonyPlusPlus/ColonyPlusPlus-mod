using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class WindowTwoHigh : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowTwoHigh() : base ()
        {
            this.TypeName = "windowtwohigh";
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

    class WindowTwoHighXMinus : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowTwoHighXMinus() : base()
        {
            this.TypeName = "windowtwohighx-";
            this.ParentType = "windowtwohigh";
            this.SideAll = "planks";

            this.Mesh = "windowtwohighx";
            this.IsBaseBlock = false;

            
        }
    }
    class WindowTwoHighXPlus : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowTwoHighXPlus() : base()
        {
            this.TypeName = "windowtwohighx+";
            this.ParentType = "windowtwohigh";
            this.SideAll = "planks";

            this.Mesh = "windowtwohighx";
            this.IsBaseBlock = false;

            
        }
    }
    class WindowTwoHighZMinus : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowTwoHighZMinus() : base()
        {
            this.TypeName = "windowtwohighz-";
            this.ParentType = "windowtwohigh";
            this.SideAll = "planks";

            this.Mesh = "windowtwohighz";
            this.IsBaseBlock = false;

            
        }
    }
    class WindowTwoHighZPlus : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WindowTwoHighZPlus() : base()
        {
            this.TypeName = "windowtwohighz+";
            this.ParentType = "windowtwohigh";
            this.SideAll = "planks";

            this.Mesh = "windowtwohighz";
            this.IsBaseBlock = false;

            
        }
    }
}
