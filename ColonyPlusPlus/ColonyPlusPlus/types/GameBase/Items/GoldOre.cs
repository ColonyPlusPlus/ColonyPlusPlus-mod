using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class GoldOre : classes.Type
    {
        public GoldOre(string name) : base(name)
        {
            this.MaxStackSize = 50;
            this.Register();
        }
    }
}
