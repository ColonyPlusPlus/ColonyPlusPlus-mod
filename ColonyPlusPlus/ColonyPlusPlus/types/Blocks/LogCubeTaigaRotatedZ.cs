using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class LogCubeTaigaRotatedZ : classes.Type
    {
        public LogCubeTaigaRotatedZ(string name) : base(name)
        {
            
            this.ParentType = "logcubetaigarotated";

            this.SideAll = "cpplogtaiga";
            this.SideZPlus = "cpplogtaigatop";
            this.SideZMinus = "cpplogtaigatop";

           
            this.Register();
        }

        
    }
}
