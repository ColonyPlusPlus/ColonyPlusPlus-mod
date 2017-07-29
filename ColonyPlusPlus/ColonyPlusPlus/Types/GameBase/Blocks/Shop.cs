using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Shop : Classes.Type
    {
        public Shop(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.SideAll = "planks";
            this.SideYPlus = "shop";
            this.IsPlaceable = true;
            this.NPCLimit = 0;
            this.Register();
        }
    }
}
