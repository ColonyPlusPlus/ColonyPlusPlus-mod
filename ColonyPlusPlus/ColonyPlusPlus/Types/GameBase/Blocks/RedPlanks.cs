using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class RedPlanks : Classes.Type
    {
        public RedPlanks(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.MaxStackSize = 200;
            this.NPCLimit = 0;
            this.FuelValue = 0.07f;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
