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
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("wheatstage1",   1,  0.8f)
            };
            this.NPCLimit = 0;
            this.ParentType = "wheatstage";
            this.SideAll = "wheatwheat";
            this.Register();
        }
    }
}
