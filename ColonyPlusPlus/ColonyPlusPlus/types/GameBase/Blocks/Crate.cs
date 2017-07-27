using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Crate : Classes.Type
    {
        public Crate(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
