using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.GameBase.Blocks
{
    class GrassTemperate : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public GrassTemperate() : base()
        {
            this.TypeName = "grasstemperate";
            this.ParentType = "grass";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Sides = "grasstemperateside";
            this.SideYMinus = "dirt";

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("grasstemperate",       1,  1.0f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheatstage1",          1,  0.1f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("sappling",             1,  0.03f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("flaxstage1",             1,  0.03f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
