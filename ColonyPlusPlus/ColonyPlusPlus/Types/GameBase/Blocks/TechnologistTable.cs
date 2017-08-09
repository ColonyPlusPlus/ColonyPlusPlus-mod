using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class TechnologistTable : Classes.Type
    {
        public TechnologistTable(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.SideAll = "coatedplanks";
            this.SideYPlus = "technologisttable";
            this.MaxStackSize = 200;
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.Register();
        }
    }
}
