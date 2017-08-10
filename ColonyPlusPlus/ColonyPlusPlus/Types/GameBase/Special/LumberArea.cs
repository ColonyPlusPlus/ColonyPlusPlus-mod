using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class LumberArea : ColonyAPI.Classes.Type
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
