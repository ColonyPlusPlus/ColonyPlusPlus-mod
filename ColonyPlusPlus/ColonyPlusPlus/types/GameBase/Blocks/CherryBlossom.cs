using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class CherryBlossom : classes.Type
    {
        public CherryBlossom(string name) : base(name)
        {
            this.ParentType = "leaves";
            this.Mesh = "cherrysapling";

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("cherryblossom",   1,  0.6f),
                new classes.ItemHelper.OnRemove("cherrysapling",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;
            this.Register();
        }
    }
}
