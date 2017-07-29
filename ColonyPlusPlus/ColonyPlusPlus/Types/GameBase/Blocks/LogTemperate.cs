using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class LogTemperate : Classes.Type
    {
        public LogTemperate(string name) : base(name)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("logtemperate",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "log";
            this.Mesh = "log";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
