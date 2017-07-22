using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class FurnaceLit : classes.Type
    {
        public FurnaceLit(string name) : base(name)
        {
            this.ParentType = "furnace";
            this.IsAutoRotatable = true;
            this.IsPlaceable = true;
            this.DestructionTime = 1250;
            this.RotatableXPlus = "furnacelitx+";
            this.RotatableXMinus = "furnacelitx-";
            this.RotatableZPlus = "furnacelitz+";
            this.RotatableZMinus = "furnacelitz-";
            this.Register();
        }
    }
    class FurnancelitxPlus : classes.Type
    {
        public FurnancelitxPlus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideAll = "furnaceside";
            this.SideXPlus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.Register();
        }
    }
    class FurnancelitxMinus : classes.Type
    {
        public FurnancelitxMinus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideAll = "furnaceside";
            this.SideXMinus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.Register();
        }
    }
    class FurnancelitzPlus : classes.Type
    {
        public FurnancelitzPlus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideAll = "furnaceside";
            this.SideZPlus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.Register();
        }
    }
    class FurnancelitzMinus : classes.Type
    {
        public FurnancelitzMinus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideAll = "furnaceside";
            this.SideZMinus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.Register();
        }
    }
}
