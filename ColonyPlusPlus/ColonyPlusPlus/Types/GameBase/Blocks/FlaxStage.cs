using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class FlaxStage : ColonyAPI.Classes.Type
    {
        public FlaxStage(string name) : base(name)
        {
            this.IsSolid = false;
            this.NeedsBase = true;
            this.SideAll = "flax";
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.AllowCreative = false;
            this.Register();
        }
    }
}
