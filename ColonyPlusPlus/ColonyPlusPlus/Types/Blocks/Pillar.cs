using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class Pillar : ColonyAPI.Classes.Type
    {
        public Pillar(string name) : base(name, true)
        {
            this.SideAll = "marble";
            this.Mesh = "log";
            this.IsPlaceable = true;

            this.AllowCreative = true;
            this.Register();
        }
    }
}
