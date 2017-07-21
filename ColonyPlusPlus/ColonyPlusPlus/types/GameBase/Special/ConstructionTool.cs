using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Special
{
    class ConstructionTool : classes.Type
    {
        public ConstructionTool(string name) : base(name)
        {
            this.Register();
        }
    }
}
