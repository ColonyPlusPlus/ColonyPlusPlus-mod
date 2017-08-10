using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class ConstructionTool : ColonyAPI.Classes.Type
    {
        public ConstructionTool(string name) : base(name)
        {
            this.Register();
        }
    }
}
