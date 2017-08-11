using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTaigaRotatedX : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTaigaRotatedX() : base(true)
        {

            this.TypeName = "logcubetaigarotatedx";
            this.ParentType = "logcubetaigarotated";

            this.SideAll = "cpplogtaiga";
            this.SideXPlus = "cpplogtaigatop";
            this.SideXMinus = "cpplogtaigatop";
            this.IsBaseBlock = false;


            
        }


    }
}
