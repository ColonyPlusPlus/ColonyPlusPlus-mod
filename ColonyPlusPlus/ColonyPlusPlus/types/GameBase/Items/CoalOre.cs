using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class CoalOre : Classes.Type
    {
        public CoalOre(string name) : base(name)
        {
            this.FuelValue = 1.0f;
            this.MaxStackSize = 50;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
