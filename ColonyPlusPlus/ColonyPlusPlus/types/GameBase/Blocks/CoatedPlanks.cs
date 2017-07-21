using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class CoatedPlanks : classes.Type
    {
        public CoatedPlanks(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.MaxStackSize = 200;
            this.NPCLimit = 20;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
