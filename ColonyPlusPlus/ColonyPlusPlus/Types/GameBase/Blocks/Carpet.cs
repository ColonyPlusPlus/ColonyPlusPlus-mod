using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Carpet : Classes.Type
    {
        public Carpet(string name) : base(name)
        {
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.MaxStackSize = 200;
            this.NPCLimit = 20;
            this.IsPlaceable = false;
            this.AllowCreative = false;
            this.Register();
        }
    }
}
