using ColonyPlusPlus.Classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class LogCubeTemperateRotatedZ : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeTemperateRotatedZ() : base(true)
        {

            this.TypeName = "logcubetemperaterotatedz";
            this.ParentType = "logcubetemperaterotated";

            this.SideAll = "cpplogtemperate";
            this.SideZPlus = "cpplogtemperatetop";
            this.SideZMinus = "cpplogtemperatetop";
            this.IsBaseBlock = false;


            
        }

        
    }
}
