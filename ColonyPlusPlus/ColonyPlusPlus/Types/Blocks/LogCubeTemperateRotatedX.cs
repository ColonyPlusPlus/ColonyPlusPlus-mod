using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeTemperateRotatedX : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTemperateRotatedX() : base(true)
        {

            this.TypeName = "logcubetemperaterotatedx";
            this.ParentType = "logcubetemperaterotated";

            this.SideAll = "cpplogtemperate";
            this.SideXPlus = "cpplogtemperatetop";
            this.SideXMinus = "cpplogtemperatetop";
            this.IsBaseBlock = false;


            this.Register();
        }


    }
}
