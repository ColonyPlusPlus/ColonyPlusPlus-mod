using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class GrassTemperate : Classes.Type
    {
        public GrassTemperate(string name) : base(name)
        {
            this.ParentType = "grass";
            this.NPCLimit = 0;
            this.IsPlaceable = true;
            this.Sides = "grasstemperateside";
            this.SideXMinus = "dirt";

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("grasstemperate",       1,  1.0f),
                new Classes.ItemHelper.OnRemove("wheatstage1",          1,  0.1f),
                new Classes.ItemHelper.OnRemove("sappling",             1,  0.03f),
                new Classes.ItemHelper.OnRemove("flaxstage1",             1,  0.03f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
