using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class LogTaiga : Classes.Type
    {
        public LogTaiga(string name) : base(name)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("logtaiga",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "log";
            this.Mesh = "log";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
