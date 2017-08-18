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
            this.SideYPlus = "grasstemperate";
            this.SideYMinus = "dirt";

            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("grasstemperate",       1,  1.0f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("wheatstage1",          1,  0.1f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("sappling",             1,  0.03f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("flaxstage1",             1,  0.03f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
