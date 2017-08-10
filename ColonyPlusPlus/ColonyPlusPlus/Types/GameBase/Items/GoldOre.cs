using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class GoldOre : ColonyAPI.Classes.Type
    {
        public GoldOre(string name) : base(name)
        {
            this.MaxStackSize = 50;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
