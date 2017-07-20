using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class Carrot : classes.Type
    {
        public Carrot(string name) : base(name)
        {
            this.Register();
        }
    }
}
