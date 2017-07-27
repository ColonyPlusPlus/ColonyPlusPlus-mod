using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Grindstone : Classes.Type
    {
        public Grindstone(string name) : base(name)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.SideAll = "planks";
            this.SideYPlus = "grindstone";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
