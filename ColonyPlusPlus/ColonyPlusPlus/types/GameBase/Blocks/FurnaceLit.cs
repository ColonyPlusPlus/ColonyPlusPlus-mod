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
            this.SideAll = "furnaceside";
            this.SideXPlus = "furnacelitfront";
            this.SideYPlus = "furnacelittop";
            this.DestructionTime = 1250;
            this.Register();
        }
    }
}
