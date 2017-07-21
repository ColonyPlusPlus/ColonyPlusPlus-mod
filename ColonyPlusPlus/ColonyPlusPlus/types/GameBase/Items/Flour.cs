using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Flour : classes.Type
    {
        public Flour(string name) : base(name)
        {
            this.MaxStackSize = 600;
            this.Register();
        }
    }
}
