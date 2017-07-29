using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class PlasterBlock : Classes.Type
    {
        public PlasterBlock(string name) : base(name)
        {
            this.OnRemoveAudio = "dirtPlace";
            this.OnPlaceAudio = "dirtPlace";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
