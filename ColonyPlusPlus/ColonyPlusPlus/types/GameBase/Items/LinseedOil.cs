using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class LinseedOil : classes.Type
    {
        public LinseedOil(string name) : base(name)
        {
            this.NPCLimit = 100;
            this.MaxStackSize = 600;
            this.Register();
        }
    }
}
