using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class FlaxStageOne : Classes.Type
    {
        public FlaxStageOne(string name) : base(name)
        {
            this.ParentType = "flaxstage";
            this.Mesh = "flaxstage1";
            this.SideAll = "flax";
            this.NPCLimit = 100;
            this.IsPlaceable = true;

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("flaxstage1",   1,  0.8f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
