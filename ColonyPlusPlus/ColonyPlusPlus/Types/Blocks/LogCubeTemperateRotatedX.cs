using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTemperateRotatedX : Classes.Type
    {
        public LogCubeTemperateRotatedX(string name) : base(name, true)
        {

            this.ParentType = "logcubetemperaterotated";

            this.SideAll = "cpplogtemperate";
            this.SideXPlus = "cpplogtemperatetop";
            this.SideXMinus = "cpplogtemperatetop";


            this.Register();
        }


    }
}
