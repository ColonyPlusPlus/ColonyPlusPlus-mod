using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.items
{
    class SugarcaneItem : classes.Type
    {
        public SugarcaneItem(string name) : base(name)
        {
            this.Register();
        }
    }
}
