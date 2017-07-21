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
}
