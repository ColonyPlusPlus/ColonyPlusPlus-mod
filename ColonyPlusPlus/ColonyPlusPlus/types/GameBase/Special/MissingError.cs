using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Special
{
    class MissingError : classes.Type
    {
        public MissingError(string name) : base(name)
        {
            this.SideAll = "error";
            this.Register();
        }
    }
}
