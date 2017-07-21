using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Special
{
    class ErrorNoFuel : classes.Type
    {
        public ErrorNoFuel(string name) : base(name)
        {
            this.ParentType = "missingerror";
            this.Icon = "errorNoFuel";
            this.Register();
        }
    }
}
