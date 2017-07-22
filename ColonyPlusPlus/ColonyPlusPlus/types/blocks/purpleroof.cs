using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class PurpleRoof : classes.Type
    {
        public PurpleRoof(string name) : base(name)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.RotatableXMinus = "purpleroofx-";
            this.RotatableXPlus = "purpleroofx+";
            this.RotatableZMinus = "purpleroofz-";
            this.RotatableZPlus = "purpleroofz+";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.IsAutoRotatable = true;
            this.Register();
        }
    }
    class PurpleRoofxMinus : classes.Type
    {
        public PurpleRoofxMinus(string name) : base(name)
        {
            this.ParentType = "purpleroof";
            this.SideAll = "planks";
            this.Mesh = "roofx-";
            this.Register();
        }
    }
    class PurpleRoofxPlus : classes.Type
    {
        public PurpleRoofxPlus(string name) : base(name)
        {
            this.ParentType = "purpleroof";
            this.SideAll = "planks";
            this.Mesh = "roofx+";
            this.Register();
        }
    }
    class PurpleRoofzMinus : classes.Type
    {
        public PurpleRoofzMinus(string name) : base(name)
        {
            this.ParentType = "purpleroof";
            this.SideAll = "planks";
            this.Mesh = "roofz-";
            this.Register();
        }
    }
    class PurpleRoofzPlus : classes.Type
    {
        public PurpleRoofzPlus(string name) : base(name)
        {
            this.ParentType = "purpleroof";
            this.SideAll = "planks";
            this.Mesh = "roofz+";
            this.Register();
        }
    }
}
