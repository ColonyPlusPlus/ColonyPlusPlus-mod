using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Arrow : ColonyAPI.Classes.Type
    {
        public Arrow(string name) : base(name)
        {
            this.NPCLimit = 200;
            this.MaxStackSize = 100;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
