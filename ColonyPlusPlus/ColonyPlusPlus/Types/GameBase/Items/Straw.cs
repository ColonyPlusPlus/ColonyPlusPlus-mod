using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Items
{
    class Straw : Classes.Type
    {
        public Straw(string name) : base(name)
        {
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.MaxStackSize = 100;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
