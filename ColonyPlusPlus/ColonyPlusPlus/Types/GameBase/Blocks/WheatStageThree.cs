using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class WheatStageThree : ColonyAPI.Classes.Type
    {
        public WheatStageThree(string name) : base(name)
        {
            this.ParentType = "wheatstage";
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage3";
            this.AllowCreative = false;

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheatstage1",   1,  1.0f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheatstage1",   1,  0.1f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheat",   1,  1.0f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("straw",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
