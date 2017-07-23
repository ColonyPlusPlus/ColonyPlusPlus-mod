using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Items
{
    class Straw : classes.Type
    {
        public Straw(string name) : base(name)
        {
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.MaxStackSize = 100;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
