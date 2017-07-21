using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class PlasterBlock : classes.Type
    {
        public PlasterBlock(string name) : base(name)
        {
            this.OnRemoveAudio = "dirtPlace";
            this.OnPlaceAudio = "dirtPlace";
            this.NPCLimit = 0;
            this.Register();
        }
    }
}
