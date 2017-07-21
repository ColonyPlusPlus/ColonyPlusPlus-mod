using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class LeavesTemperate : classes.Type
    {
        public LeavesTemperate(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("leavestemperate",   1,  0.6f),
                new classes.ItemHelper.OnRemove("sappling",   1,  0.1f),
                new classes.ItemHelper.OnRemove("feather",   2,  0.1f),
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "leaves";
            this.Register();
        }
    }
}
