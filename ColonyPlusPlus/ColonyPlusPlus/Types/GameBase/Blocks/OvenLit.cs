using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class OvenLit : ColonyAPI.Classes.Type
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
            this.AllowCreative = false;
            this.Register();
        }
    }

    class OvenLitxPlus : ColonyAPI.Classes.Type
    {
        public OvenLitxPlus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideAll = "stonebricks";
            this.SideXPlus = "ovenlitfront";
            this.Register();
        }
    }
    class OvenLitxMinus : ColonyAPI.Classes.Type
    {
        public OvenLitxMinus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideAll = "stonebricks";
            this.SideXMinus = "ovenlitfront";
            this.Register();
        }
    }
    class OvenLitzPlus : ColonyAPI.Classes.Type
    {
        public OvenLitzPlus(string name) : base(name)
        {
            this.ParentType = "ovenlit";
            this.SideAll = "stonebricks";
            this.SideZPlus = "ovenlitfront";
            this.Register();
        }
    }
    class OvenLitzMinus : ColonyAPI.Classes.Type
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
