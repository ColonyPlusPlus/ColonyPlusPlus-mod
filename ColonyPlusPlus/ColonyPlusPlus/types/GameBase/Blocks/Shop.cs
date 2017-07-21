using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Shop : classes.Type
    {
        public Shop(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.SideAll = "planks";
            this.SideYPlus = "shop";
            this.NPCLimit = 0;
            this.Register();
        }
    }
}
