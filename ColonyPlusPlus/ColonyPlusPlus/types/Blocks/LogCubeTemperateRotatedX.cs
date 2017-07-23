using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class LogCubeTemperateRotatedX : classes.Type
    {
        public LogCubeTemperateRotatedX(string name) : base(name)
        {

            this.ParentType = "logcubetemperaterotated";

            this.SideAll = "cpplogtemperate";
            this.SideXPlus = "cpplogtemperatetop";
            this.SideXMinus = "cpplogtemperatetop";


            this.Register();
        }


    }
}
