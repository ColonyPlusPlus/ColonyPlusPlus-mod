using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class GoldCoin : classes.Type
    {
        public GoldCoin(string name) : base(name)
        {
            this.MaxStackSize = 400;
            this.Register();
        }
    }
}
