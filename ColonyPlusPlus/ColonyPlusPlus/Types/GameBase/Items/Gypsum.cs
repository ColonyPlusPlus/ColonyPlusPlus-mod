using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Gypsum : ColonyAPI.Classes.Type
    {
        public Gypsum(string name) : base(name)
        {
            this.MaxStackSize = 200;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
