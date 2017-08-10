using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class CoatedPlanks : ColonyAPI.Classes.Type
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
