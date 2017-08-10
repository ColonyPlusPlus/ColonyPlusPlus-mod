using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class CherryBlossom : ColonyAPI.Classes.Type
    {
        public CherryBlossom(string name) : base(name)
        {
            this.ParentType = "leaves";
            this.IsPlaceable = true;

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("cherryblossom",   1,  0.6f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("cherrysapling",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
