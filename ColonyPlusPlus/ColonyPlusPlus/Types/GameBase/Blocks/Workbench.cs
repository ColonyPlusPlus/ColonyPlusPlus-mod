using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Workbench : Classes.Type
    {
        public Workbench(string name) : base(name)
        {
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";
            this.SideAll = "planks";
            this.SideYPlus = "workbenchtop";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
