using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class LeavesTemperate : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LeavesTemperate() : base()
        {
            this.TypeName = "leavestemperate";
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("leavestemperate",   1,  0.6f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("sappling",   1,  0.1f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("feather",   2,  0.1f),
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "leaves";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
