using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTaigaRotatedX : Classes.Type
    {
        public LogCubeTaigaRotatedX(string name) : base(name, true)
        {

            this.ParentType = "logcubetaigarotated";

            this.SideAll = "cpplogtaiga";
            this.SideXPlus = "cpplogtaigatop";
            this.SideXMinus = "cpplogtaigatop";
            this.IsBaseBlock = false;


            this.Register();
        }


    }
}
