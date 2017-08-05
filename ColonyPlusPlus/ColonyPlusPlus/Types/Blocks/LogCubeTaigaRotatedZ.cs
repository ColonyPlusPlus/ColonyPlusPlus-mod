using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTaigaRotatedZ : Classes.Type
    {
        public LogCubeTaigaRotatedZ(string name) : base(name, true)
        {
            
            this.ParentType = "logcubetaigarotated";

            this.SideAll = "cpplogtaiga";
            this.SideZPlus = "cpplogtaigatop";
            this.SideZMinus = "cpplogtaigatop";
            this.IsBaseBlock = false;


            this.Register();
        }

        
    }
}
