using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class LinseedOil : Classes.Type
    {
        public LinseedOil(string name) : base(name)
        {
            this.NPCLimit = 100;
            this.MaxStackSize = 600;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
