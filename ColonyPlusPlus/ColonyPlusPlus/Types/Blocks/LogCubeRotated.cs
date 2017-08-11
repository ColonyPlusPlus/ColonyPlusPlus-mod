using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeRotated : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCubeRotated() : base(true)
        {

            this.TypeName = "logcuberotated";
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.FuelValue = 0.6f;
            this.IsBaseBlock = false;
            
        }
    }
}
