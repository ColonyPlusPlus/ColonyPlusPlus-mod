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
            this.IsPlaceable = true;
            this.Register();
        }
    }

    class OvenLitxPlus : classes.Type
    {
        public OvenLitxPlus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideAll = "stonebricks";
            this.SideXPlus = "ovenlitfront";
            this.Register();
        }
    }
    class OvenLitxMinus : classes.Type
    {
        public OvenLitxMinus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideAll = "stonebricks";
            this.SideXMinus = "ovenlitfront";
            this.Register();
        }
    }
    class OvenLitzPlus : classes.Type
    {
        public OvenLitzPlus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideAll = "stonebricks";
            this.SideZPlus = "ovenlitfront";
            this.Register();
        }
    }
    class OvenLitzMinus : classes.Type
    {
        public OvenLitzMinus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideAll = "stonebricks";
            this.SideZMinus = "ovenlitfront";
            this.Register();
        }
    }
}
