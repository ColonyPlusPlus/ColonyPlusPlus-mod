using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBaseItems
{
    class Air : classes.Type
    {
        public Air(string name) : base(name)
        {
            this.IsSolid = false;
            this.Register();
        }
    }
}
