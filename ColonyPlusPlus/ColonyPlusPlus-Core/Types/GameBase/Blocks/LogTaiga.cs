using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.GameBase.Blocks
{
    class LogTaiga : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public LogTaiga() : base()
        {
            this.TypeName = "logtaiga";
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("logtaiga",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.ParentType = "log";
            this.Mesh = "log";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
