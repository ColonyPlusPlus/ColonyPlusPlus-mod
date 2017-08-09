using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class CarpetBlue : Classes.Type
    {
        public CarpetBlue(string name) : base(name)
        {
            this.ParentType = "carpet";
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
