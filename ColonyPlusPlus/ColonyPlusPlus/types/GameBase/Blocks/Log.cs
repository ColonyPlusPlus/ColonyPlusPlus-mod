using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Log : Classes.Type
    {
        public Log(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.FuelValue = 0.6f;
            this.Register();
        }
    }
}
