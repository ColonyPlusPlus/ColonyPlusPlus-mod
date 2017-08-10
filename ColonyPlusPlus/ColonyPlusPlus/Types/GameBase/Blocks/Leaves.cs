using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Leaves : ColonyAPI.Classes.Type
    {
        public Leaves(string name) : base(name)
        {
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.DestructionTime = 200;
            this.Register();
        }
    }
}
