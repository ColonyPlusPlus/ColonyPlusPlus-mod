using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class FlaxStageTwo : classes.Type
    {
        public FlaxStageTwo(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("flaxstage1",   1,  1.1f),
                new classes.ItemHelper.OnRemove("flax",   3,  1f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "flaxstage";
            this.Register();
        }
    }
}
