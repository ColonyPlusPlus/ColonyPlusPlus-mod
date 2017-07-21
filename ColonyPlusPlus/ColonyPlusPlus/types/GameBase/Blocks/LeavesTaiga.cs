using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class LeavesTaiga : classes.Type
    {
        public LeavesTaiga(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("leavestaiga",   1,  0.6f),
                new classes.ItemHelper.OnRemove("sappling",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "leaves";
            this.Register();
        }
    }
}
