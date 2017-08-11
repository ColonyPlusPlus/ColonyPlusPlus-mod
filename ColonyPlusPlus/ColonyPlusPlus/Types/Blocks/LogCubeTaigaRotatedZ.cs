using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTaigaRotatedZ : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTaigaRotatedZ() : base(true)
        {

            this.TypeName = "logcubetaigarotatedz";
            this.ParentType = "logcubetaigarotated";

            this.SideAll = "cpplogtaiga";
            this.SideZPlus = "cpplogtaigatop";
            this.SideZMinus = "cpplogtaigatop";
            this.IsBaseBlock = false;


            this.Register();
        }

        
    }
}
