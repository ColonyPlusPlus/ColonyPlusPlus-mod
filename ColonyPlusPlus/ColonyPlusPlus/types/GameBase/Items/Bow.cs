using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Bow : classes.Type
    {
        public Bow(string name) : base(name)
        {
            this.NPCLimit = 1;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
