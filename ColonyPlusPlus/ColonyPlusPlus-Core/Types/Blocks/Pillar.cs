using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class Pillar : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Pillar() : base(true)
        {
            this.TypeName = "pillar";
            this.SideAll = "marble";
            this.Mesh = "log";
            this.IsPlaceable = true;

            this.AllowCreative = true;
            
        }
    }
}
