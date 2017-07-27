using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Special
{
    class CommandTool : Classes.Type
    {
        public CommandTool(string name) : base(name)
        {
            this.Register();
        }
    }
}
