using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Grass : Classes.Type
    {
        public Grass(string name) : base(name)
        {
            this.IsFertile = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.MaxStackSize = 100;
            this.Register();
        }
    }
}
