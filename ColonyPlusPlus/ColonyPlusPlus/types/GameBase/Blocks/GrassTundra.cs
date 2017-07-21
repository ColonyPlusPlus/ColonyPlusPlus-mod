using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class GrassTundra : classes.Type
    {
        public GrassTundra(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("grasstundra",   1,  1.0f),
                new classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.ParentType = "grass";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
