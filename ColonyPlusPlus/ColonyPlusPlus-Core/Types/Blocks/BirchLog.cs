using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus_Core.Types.Blocks
{
    class BirchLog : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public BirchLog() : base(true)
        {
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("birchlog",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;

            this.TypeName = "birchlog";
            this.OnPlaceAudio = "woodPlace";
            this.OnRemoveAudio = "woodDeleteLight";

            this.Mesh = "birchlog";
            this.SideAll = "cpplogbirch";
            this.SideYPlus = "cpplogtaigatop";
            this.SideYMinus = "cpplogtaigatop";

            this.FuelValue = 0.6f;
            this.IsBaseBlock = false;

            this.AllowCreative = true;
            this.IsPlaceable = true;
        }
    }
}
