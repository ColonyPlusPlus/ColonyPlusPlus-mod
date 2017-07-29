using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class ErrorNoPath : Classes.Type
    {
        public ErrorNoPath(string name) : base(name)
        {
            this.ParentType = "missingerror";
            this.Icon = "errorNoPath";
            this.Register();
        }
    }
}
