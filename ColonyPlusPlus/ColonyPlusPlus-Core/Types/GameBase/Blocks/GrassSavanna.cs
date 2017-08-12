using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.GameBase.Blocks
{
    class GrassSavanna : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public GrassSavanna() : base()
        {
            this.TypeName = "grasssavanna";
            this.ParentType = "grass";
            this.IsPlaceable = true;

            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("grasssavanna",   1,  1.0f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
