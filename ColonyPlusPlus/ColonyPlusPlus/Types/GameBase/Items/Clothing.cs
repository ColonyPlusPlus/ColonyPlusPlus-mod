using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Clothing : ColonyAPI.Classes.Type
    {
        public Clothing(string name) : base(name)
        {
            this.MaxStackSize = 25;
            this.Icon = "clothing";
            this.IsPlaceable = false;
            this.NPCLimit = 4;
            this.Register();
        }
    }
}
