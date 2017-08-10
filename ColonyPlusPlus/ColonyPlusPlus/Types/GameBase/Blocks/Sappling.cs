using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Sappling : ColonyAPI.Classes.Type
    {
        public Sappling(string name) : base(name)
        {
            this.IsSolid = false;
            this.NeedsBase = true;
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "grassDelete";
            this.Mesh = "sapling";
            this.Icon = "sapling";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
