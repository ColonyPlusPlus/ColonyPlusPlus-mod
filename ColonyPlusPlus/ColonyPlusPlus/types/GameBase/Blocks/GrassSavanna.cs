using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class GrassSavanna : Classes.Type
    {
        public GrassSavanna(string name) : base(name)
        {
            this.ParentType = "grass";
            this.IsPlaceable = true;

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("grasssavanna",   1,  1.0f),
                new Classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
