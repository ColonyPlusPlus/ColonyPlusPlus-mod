using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Flax : ColonyAPI.Classes.Type
    {
        public Flax(string name) : base(name)
        {
            this.MaxStackSize = 600;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
