using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types
{
    class Sugar : classes.Type
    {
        public Sugar(string name) : base(name)
        {
            this.Register();
        }
    }
}
