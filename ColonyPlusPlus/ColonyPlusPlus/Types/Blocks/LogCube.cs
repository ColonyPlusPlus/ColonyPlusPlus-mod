using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCube : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogCube() : base(true)
        {

            this.TypeName = "logcube";
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.FuelValue = 0.6f;
            this.IsBaseBlock = false;
            ) : base()
        }
    }
}
