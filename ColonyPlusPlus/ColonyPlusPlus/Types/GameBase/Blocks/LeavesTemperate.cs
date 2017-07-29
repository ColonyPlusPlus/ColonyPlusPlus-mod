using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class LeavesTemperate : Classes.Type
    {
        public LeavesTemperate(string name) : base(name)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("leavestemperate",   1,  0.6f),
                new Classes.ItemHelper.OnRemove("sappling",   1,  0.1f),
                new Classes.ItemHelper.OnRemove("feather",   2,  0.1f),
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "leaves";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
