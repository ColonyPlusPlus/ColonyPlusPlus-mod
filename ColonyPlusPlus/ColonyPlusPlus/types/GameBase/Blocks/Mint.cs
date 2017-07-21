using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Mint : classes.Type
    {
        public Mint(string name) : base(name)
        {
            this.OnPlaceAudio = "stonePlace";
            this.OnRemoveAudio = "stoneDelete";
            this.SideAll = "planks";
            this.SideYMinus = "mint";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
