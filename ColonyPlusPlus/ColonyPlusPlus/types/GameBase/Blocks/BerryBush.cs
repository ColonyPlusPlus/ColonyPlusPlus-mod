using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class BerryBush : Classes.Type
    {
        public BerryBush(string name) : base(name)
        {
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.NPCLimit = 0;
            this.Register();
        }
    }
}
