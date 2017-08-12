using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.GameBase.Blocks
{
    class LeavesTaiga : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LeavesTaiga() : base()
        {
            this.TypeName = "leavestaiga";
            this.ParentType = "leaves";
            this.IsPlaceable = true;

            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("leavestaiga",   1,  0.6f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("sappling",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
