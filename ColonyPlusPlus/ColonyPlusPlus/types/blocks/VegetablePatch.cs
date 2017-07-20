using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.blocks
{
    class VegetablePatch : classes.Type
    {
        public VegetablePatch(string name) : base(name)
        {
            this.Register();
        }
    }
}
