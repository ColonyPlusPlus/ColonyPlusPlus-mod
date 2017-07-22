using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class WheatStageOne : classes.Type
    {
        public WheatStageOne(string name) : base(name)
        {
            this.ParentType = "wheatstage";
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage1";
            this.IsPlaceable = true;
            this.NPCLimit = 0;

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("wheatstage1",   1,  0.8f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
