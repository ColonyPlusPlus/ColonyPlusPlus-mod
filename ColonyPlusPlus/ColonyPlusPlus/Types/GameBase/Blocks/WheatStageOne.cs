using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class WheatStageOne : ColonyAPI.Classes.Type
    {
        public WheatStageOne(string name) : base(name)
        {
            this.ParentType = "wheatstage";
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage1";
            this.IsPlaceable = true;
            this.AllowCreative = true;
            this.NPCLimit = 0;

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheatstage1",   1,  0.8f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
