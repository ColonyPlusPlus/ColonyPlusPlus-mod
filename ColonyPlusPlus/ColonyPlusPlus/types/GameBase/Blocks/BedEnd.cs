using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class BedEnd : classes.Type
    {
        public BedEnd(string name) : base(name)
        {
            this.ParentType = "bed";
            this.IsAutoRotatable = true;
            this.Register();
        }
    }
}
