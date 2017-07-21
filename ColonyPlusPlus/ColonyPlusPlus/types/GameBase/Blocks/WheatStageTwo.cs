using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class WheatStageTwo : classes.Type
    {
        public WheatStageTwo(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("wheatstage1",   1,  0.8f),
                new classes.ItemHelper.OnRemove("wheat",   1,  0.03f),
                new classes.ItemHelper.OnRemove("straw",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "wheatstage";
            this.SideAll = "wheatwheat";

            this.Register();
        }
    }
}
