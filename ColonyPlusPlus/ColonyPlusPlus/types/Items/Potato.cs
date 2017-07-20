using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types
{
    class Potato : classes.Type
    {
        public Potato(string name) : base(name)
        {
            this.Register();
        }
    }
}
