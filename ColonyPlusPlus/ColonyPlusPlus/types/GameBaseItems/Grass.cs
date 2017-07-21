using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBaseItems
{
    class Grass : classes.Type
    {
        public Grass(string name) : base(name)
        {
            this.IsFertile = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.Register();
        }
    }
}
