using ColonyPlusPlus.classes.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.Blocks
{
    class LogCubeTemperateRotatedZ : classes.Type
    {
        public LogCubeTemperateRotatedZ(string name) : base(name)
        {
            
            this.ParentType = "logcubetemperaterotated";

            this.SideAll = "cpplogtemperate";
            this.SideZPlus = "cpplogtemperatetop";
            this.SideZMinus = "cpplogtemperatetop";

           
            this.Register();
        }

        
    }
}
