using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Grass : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public Grass() : base()
        {
            this.TypeName = "grass";
            this.IsFertile = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.MaxStackSize = 200;
            this.Register();
        }
    }
}
