using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Gypsum : classes.Type
    {
        public Gypsum(string name) : base(name)
        {
            this.MaxStackSize = 200;
            this.Register();
        }
    }
}
