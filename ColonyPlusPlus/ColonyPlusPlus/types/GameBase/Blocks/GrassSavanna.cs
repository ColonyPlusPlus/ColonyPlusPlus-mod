using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class GrassSavanna : classes.Type
    {
        public GrassSavanna(string name) : base(name)
        {
            this.ParentType = "grass";
            this.IsPlaceable = true;

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("grasssavanna",   1,  1.0f),
                new classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
