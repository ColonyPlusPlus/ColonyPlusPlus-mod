using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class WellTop : Classes.Type
    {
        public WellTop(string name) : base(name, true)
        {
            this.SideAll = "planks";
            this.Mesh = "wellroof";
            this.IsPlaceable = true;

            this.AllowCreative = true;

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("welltop", 1, 1.0f)
            };

            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
