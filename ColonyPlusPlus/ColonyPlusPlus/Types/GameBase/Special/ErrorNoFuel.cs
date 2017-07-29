using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class ErrorNoFuel : Classes.Type
    {
        public ErrorNoFuel(string name) : base(name)
        {
            this.ParentType = "missingerror";
            this.Icon = "errorNoFuel";
            this.Register();
        }
    }
}
