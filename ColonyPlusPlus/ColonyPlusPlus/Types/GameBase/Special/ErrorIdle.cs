using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class ErrorIdle : ColonyAPI.Classes.Type
    {
        public ErrorIdle(string name) : base(name)
        {
            this.ParentType = "missingerror";
            this.Icon = "errorIdle";
            this.Register();
        }
    }
}
