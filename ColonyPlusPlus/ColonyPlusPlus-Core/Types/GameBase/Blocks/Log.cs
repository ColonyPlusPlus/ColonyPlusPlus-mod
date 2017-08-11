using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Log : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Log() : base()
        {
            this.TypeName = "log";
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.FuelValue = 0.6f;
            this.Register();
        }
    }
}
