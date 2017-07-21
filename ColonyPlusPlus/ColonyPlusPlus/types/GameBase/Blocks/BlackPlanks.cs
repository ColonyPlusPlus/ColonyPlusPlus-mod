using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class BlackPlanks : classes.Type
    {
        public BlackPlanks(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.MaxStackSize = 200;
            this.NPCLimit = 0;
            this.FuelValue = 0.5f;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
