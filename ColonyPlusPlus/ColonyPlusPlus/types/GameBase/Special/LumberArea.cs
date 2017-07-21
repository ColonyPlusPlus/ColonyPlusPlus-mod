using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Special
{
    class LumberArea : classes.Type
    {
        public LumberArea(string name) : base(name)
        {
            this.OnRemoveAudio = "grasstemperate";
            this.OnPlaceAudio = "dirtPlace";
            this.IsFertile = true;
            this.Register();
        }
    }
}
