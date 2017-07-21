using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Special
{
    class ErrorIdle : classes.Type
    {
        public ErrorIdle(string name) : base(name)
        {
            this.ParentType = "missingerror";
            this.Icon = "errorIdle";
            this.Register();
        }
    }
}
