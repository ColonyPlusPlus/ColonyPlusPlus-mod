using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class FlaxStageTwo : Classes.Type
    {
        public FlaxStageTwo(string name) : base(name)
        {
            this.ParentType = "flaxstage";
            this.Mesh = "flaxstage2";
            this.SideAll = "flax";

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("flaxstage1",   1,  1.1f),
                new Classes.ItemHelper.OnRemove("flax",   3,  1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
