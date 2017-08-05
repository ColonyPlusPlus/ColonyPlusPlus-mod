using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class TailorShop : Classes.Type
    {
        public TailorShop(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.SideAll = "planks";
            this.SideXPlus = "tailorshop";
            this.NPCLimit = 0;
            this.Register();
        }
    }
}
