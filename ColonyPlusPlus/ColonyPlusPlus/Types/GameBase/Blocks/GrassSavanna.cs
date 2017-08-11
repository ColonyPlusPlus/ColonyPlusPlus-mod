using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class GrassSavanna : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public GrassSavanna() : base()
        {
            this.ParentType = "grass";
            this.IsPlaceable = true;

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("grasssavanna",   1,  1.0f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheatstage1",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
