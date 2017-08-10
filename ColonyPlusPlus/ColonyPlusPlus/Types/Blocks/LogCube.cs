using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class LogCube : ColonyAPI.Classes.Type
    {
        public LogCube(string name) : base(name, true)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.FuelValue = 0.6f;
            this.IsBaseBlock = false;
            this.Register();
        }
    }
}
