using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class StoneBricks : classes.Type
    {
        public StoneBricks(string name) : base(name)
        {
            this.DestructionTime = 600;
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.Register();
        }
    }
}
