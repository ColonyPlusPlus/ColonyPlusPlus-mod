using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Special
{
    class CommandTool : classes.Type
    {
        public CommandTool(string name) : base(name)
        {
            this.Register();
        }
    }
}
