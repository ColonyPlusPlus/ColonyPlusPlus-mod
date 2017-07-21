using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Special
{
    class ErrorNoPath : classes.Type
    {
        public ErrorNoPath(string name) : base(name)
        {
            this.ParentType = "missingerror";
            this.icon = "errorNoPath.png";
            this.Register();
        }
    }
}
