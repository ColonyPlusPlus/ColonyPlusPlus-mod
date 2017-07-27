using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Snow : Classes.Type
    {
        public Snow(string name) : base(name)
        {
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
