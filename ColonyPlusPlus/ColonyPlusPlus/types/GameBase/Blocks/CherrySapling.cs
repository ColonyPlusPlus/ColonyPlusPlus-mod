using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class CherrySapling : classes.Type
    {
        public CherrySapling(string name) : base(name)
        {
            this.IsSolid = false;
            this.NeedsBase = true;
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "grassDelete";
            this.SideAll = "sappling";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Mesh = "sapling";
            this.Register();
        }
    }
}
