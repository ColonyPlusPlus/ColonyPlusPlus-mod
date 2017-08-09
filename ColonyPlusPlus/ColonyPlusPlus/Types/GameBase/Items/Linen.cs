using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Linen : Classes.Type
    {
        public Linen(string name) : base(name)
        {
            this.NPCLimit = 4;
            this.MaxStackSize = 100;
            this.AllowCreative = true;
            this.IsPlaceable = false;
            this.Register();
        }
    }
}
