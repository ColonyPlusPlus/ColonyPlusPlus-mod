using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class GoldCoin : ColonyAPI.Classes.Type
    {
        public GoldCoin(string name) : base(name)
        {
            this.MaxStackSize = 400;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
