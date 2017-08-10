using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class FlaxStageTwo : ColonyAPI.Classes.Type
    {
        public FlaxStageTwo(string name) : base(name)
        {
            this.ParentType = "flaxstage";
            this.Mesh = "flaxstage2";
            this.SideAll = "flax";

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("flaxstage1",   1,  1.1f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("flax",   3,  1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
