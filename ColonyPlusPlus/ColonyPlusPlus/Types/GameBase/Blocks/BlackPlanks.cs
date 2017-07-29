using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class BlackPlanks : Classes.Type
    {
        public BlackPlanks(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.MaxStackSize = 200;
            this.NPCLimit = 0;
            this.FuelValue = 0.5f;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
