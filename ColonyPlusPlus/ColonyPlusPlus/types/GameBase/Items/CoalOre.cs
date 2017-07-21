using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class CoalOre : classes.Type
    {
        public CoalOre(string name) : base(name)
        {
            this.FuelValue = 1.0f;
            this.MaxStackSize = 50;
            this.Register();
        }
    }
}
