using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class GoldIngot : classes.Type
    {
        public GoldIngot(string name) : base(name)
        {
            this.MaxStackSize = 200;
            this.Register();
        }
    }
}
