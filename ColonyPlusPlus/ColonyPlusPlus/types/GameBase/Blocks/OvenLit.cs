using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class OvenLit : classes.Type
    {
        public OvenLit(string name) : base(name)
        {
            this.ParentType = "oven";
            this.IsAutoRotatable = true;
            this.SideAll = "stonebricks";
            this.SideXPlus = "ovenlitfront";
            this.DestructionTime = 1250;
            this.RotatableXMinus = "ovenlitx-";
            this.RotatableXPlus = "ovenlitx+";
            this.RotatableZMinus = "ovenlitz-";
            this.RotatableZPlus = "ovenz+";
            this.Register();
        }
    }

    class OverLitxPlus : classes.Type
    {
        public OverLitxPlus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideXPlus = "ovenlitfront";
            this.Register();
        }
    }
    class OverLitxMinus : classes.Type
    {
        public OverLitxMinus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideXMinus = "ovenlitfront";
            this.Register();
        }
    }
    class OverLitzPlus : classes.Type
    {
        public OverLitzPlus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideZPlus = "ovenlitfront";
            this.Register();
        }
    }
    class OverLitzMinus : classes.Type
    {
        public OverLitzMinus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideZMinus = "ovenlitfront";
            this.Register();
        }
    }
}
