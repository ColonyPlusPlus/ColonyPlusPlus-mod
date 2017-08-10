using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class ScienceBagLife : ColonyAPI.Classes.Type
    {
        public ScienceBagLife(string name) : base(name)
        {
            this.NPCLimit = 5;
            this.MaxStackSize = 50;
            this.AllowCreative = true;
            this.IsPlaceable = false;
            this.Icon = "sciencebaglife";
            this.Register();
        }
    }
}
