using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class SaveTool : ColonyAPI.Classes.Type
    {
        public SaveTool(string name) : base(name)
        {
            this.Register();
        }
    }
}
