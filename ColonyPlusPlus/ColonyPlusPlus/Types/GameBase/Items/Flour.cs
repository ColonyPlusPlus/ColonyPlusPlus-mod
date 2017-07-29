using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Flour : Classes.Type
    {
        public Flour(string name) : base(name)
        {
            this.MaxStackSize = 600;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
