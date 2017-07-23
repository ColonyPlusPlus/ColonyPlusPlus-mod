using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class LogCubeTaigaRotatedX : classes.Type
    {
        public LogCubeTaigaRotatedX(string name) : base(name)
        {

            this.ParentType = "logcubetaigarotated";

            this.SideAll = "cpplogtaiga";
            this.SideXPlus = "cpplogtaigatop";
            this.SideXMinus = "cpplogtaigatop";


            this.Register();
        }


    }
}
