using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Bed : classes.Type
    {
        public Bed(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.IsAutoRotatable = true;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
