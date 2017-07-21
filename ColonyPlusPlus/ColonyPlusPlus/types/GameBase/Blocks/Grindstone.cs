using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Grindstone : classes.Type
    {
        public Grindstone(string name) : base(name)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.SideAll = "planks";
            this.SideYPlus = "grindstone";
            this.NPCLimit = 0;
            this.Register();
        }
    }
}
