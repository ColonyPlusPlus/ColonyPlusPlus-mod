using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Dirt : classes.Type
    {
        public Dirt(string name) : base(name)
        {
            this.NPCLimit = 0;
            this.IsFertile = true;
            this.SideAll = "SELF";
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
