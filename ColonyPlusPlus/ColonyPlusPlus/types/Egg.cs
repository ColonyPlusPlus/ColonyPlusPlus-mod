using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types
{
    class Egg : classes.Type
    {
        public Egg(string name) : base(name)
        {
            this.Register();
        }
    }
}
