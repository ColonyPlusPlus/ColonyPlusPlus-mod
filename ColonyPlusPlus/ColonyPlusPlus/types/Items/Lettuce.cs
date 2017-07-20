using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.items
{
    class Lettuce : classes.Type
    {
        public Lettuce(string name) : base(name)
        {
            this.Register();
        }
    }
}
