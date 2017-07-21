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
            this.SideAll = "furnaceside";
            this.SideXPlus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
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
            this.SideXPlus = "furnacelitfront";
            this.Register();
        }
    }
    class FurnancelitxMinus : classes.Type
    {
        public FurnancelitxMinus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideXMinus = "furnacelitfront";
            this.Register();
        }
    }
    class FurnancelitzPlus : classes.Type
    {
        public FurnancelitzPlus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideZPlus = "furnacelitfront";
            this.Register();
        }
    }
    class FurnancelitzMinus : classes.Type
    {
        public FurnancelitzMinus(string name) : base(name)
        {
            this.ParentType = "furnacelit";
            this.SideZMinus = "furnacelitfront";
            this.Register();
        }
    }
}
