using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class LogTemperate : classes.Type
    {
        public LogTemperate(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("logtemperate",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "log";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
