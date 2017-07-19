using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.types
{
    public class newdirt : classes.Type
    {

        public newdirt(string name) : base(name)
        {
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.SideAll = "SELF";

            this.Register();
        }

    }
}
