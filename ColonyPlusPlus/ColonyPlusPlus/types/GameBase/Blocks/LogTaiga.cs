using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class LogTaiga : classes.Type
    {
        public LogTaiga(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("logtaiga",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "log";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
