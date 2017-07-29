using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class MissingError : Classes.Type
    {
        public MissingError(string name) : base(name)
        {
            this.SideAll = "error";
            this.Register();
        }
    }
}
