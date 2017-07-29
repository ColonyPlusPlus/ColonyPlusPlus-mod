using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Pickaxe : Classes.Type
    {
        public Pickaxe(string name) : base(name)
        {
            this.NPCLimit = 1;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
