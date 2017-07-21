using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Flax : classes.Type
    {
        public Flax(string name) : base(name)
        {
            this.MaxStackSize = 600;
            this.Register();
        }
    }
}
