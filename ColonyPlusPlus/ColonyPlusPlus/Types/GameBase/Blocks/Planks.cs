using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Planks : Classes.Type
    {
        public Planks(string name) : base(name)
        {
            this.OnRemoveAudio = "woodDeleteLight";
            this.OnPlaceAudio = "woodPlace";
            this.MaxStackSize = 200;
            this.NPCLimit = 30;
            this.FuelValue = 0.12f;
            this.IsPlaceable = true;

            this.Register();
        }
    }
}
