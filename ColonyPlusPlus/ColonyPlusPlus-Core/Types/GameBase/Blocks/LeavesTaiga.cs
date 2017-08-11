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

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("leavestaiga",   1,  0.6f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("sappling",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
