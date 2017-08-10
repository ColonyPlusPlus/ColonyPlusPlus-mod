using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class CherrySapling : ColonyAPI.Classes.Type
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
            this.Mesh = "cherrysapling";
            this.Register();
        }
    }
}
