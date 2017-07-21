using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBaseItems
{
    class GrassSavanna : classes.Type
    {
        public GrassSavanna(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("grasssavanna",   1,  1.0f),
                new classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.ParentType = "grass";
            this.Register();
        }
    }
}
