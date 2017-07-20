using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.items
{
    class Cheese : classes.Type
    {
        public Cheese(string name) : base(name)
        {
            this.Register();
        }
    }
}
