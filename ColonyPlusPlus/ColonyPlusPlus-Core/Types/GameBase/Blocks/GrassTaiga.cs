using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.GameBase.Blocks
{
    class GrassTaiga : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public GrassTaiga() : base()
        {
            this.TypeName = "grasstaiga";
            this.ParentType = "grass";
            this.IsPlaceable = true;

            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("grasstaiga",   1,  1.0f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("sappling",     1,  0.03f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
