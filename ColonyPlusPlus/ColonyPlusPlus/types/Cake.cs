using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types
{
    class Cake : classes.Type
    {
        public Cake(string name) : base(name)
        {
            this.Register();
        }
    }
}
