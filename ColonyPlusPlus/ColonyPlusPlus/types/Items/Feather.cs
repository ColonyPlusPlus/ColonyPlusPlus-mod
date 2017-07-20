using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Feather : classes.Type
    {
        public Feather(string name) : base(name)
        {
            this.Register();
        }
    }
}
