using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Sand : classes.Type
    {
        public Sand(string name) : base(name)
        {
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.IsPlaceable = true;
            this.Register();
            
        }
    }
}
