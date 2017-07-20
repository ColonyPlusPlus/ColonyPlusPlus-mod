using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.items
{
    class Omlette : classes.Type
    {
        public Omlette(string name) : base(name)
        {
            this.Register();
        }
    }
}
