using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Bricks : classes.Type
    {
        public Bricks(string name) : base(name)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.NPCLimit = 20;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
