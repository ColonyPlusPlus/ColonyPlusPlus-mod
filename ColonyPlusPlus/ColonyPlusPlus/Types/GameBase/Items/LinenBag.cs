using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class LinenBag : ColonyAPI.Classes.Type
    {
        public LinenBag(string name) : base(name)
        {
            this.NPCLimit = 5;
            this.MaxStackSize = 50;
            this.AllowCreative = true;
            this.IsPlaceable = false;
            this.Register();
        }
    }
}
