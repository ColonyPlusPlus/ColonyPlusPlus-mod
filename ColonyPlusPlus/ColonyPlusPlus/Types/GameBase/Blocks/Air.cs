using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Air : Classes.Type
    {
        public Air(string name) : base(name)
        {
            this.IsSolid = false;
            this.Register();
        }
    }
}
