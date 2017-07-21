using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Axe : classes.Type
    {
        public Axe(string name) : base(name)
        {
            this.NPCLimit = 1;
            this.Register();
        }
    }
}
