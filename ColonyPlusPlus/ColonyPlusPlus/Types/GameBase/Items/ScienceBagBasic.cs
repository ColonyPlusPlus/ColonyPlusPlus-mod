using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class ScienceBagBasic : ColonyAPI.Classes.Type
    {
        public ScienceBagBasic(string name) : base(name)
        {
            this.NPCLimit = 5;
            this.MaxStackSize = 50;
            this.AllowCreative = true;
            this.IsPlaceable = false;
            this.Icon = "sciencebagbasic";
            this.Register();
        }
    }
}
