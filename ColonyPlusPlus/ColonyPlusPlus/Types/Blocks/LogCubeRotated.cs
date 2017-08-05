using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCubeRotated : Classes.Type
    {
        public LogCubeRotated(string name) : base(name, true)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.FuelValue = 0.6f;
            this.Register();
        }
    }
}
