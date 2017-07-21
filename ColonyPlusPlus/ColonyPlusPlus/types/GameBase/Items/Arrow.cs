using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Arrow : classes.Type
    {
        public Arrow(string name) : base(name)
        {
            this.NPCLimit = 200;
            this.MaxStackSize = 100;
            this.Register();
        }
    }
}
