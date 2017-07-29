using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Water : Classes.Type
    {
        public Water(string name) : base(name)
        {
            this.IsSolid = false;
            this.Register();
        }
    }
}
