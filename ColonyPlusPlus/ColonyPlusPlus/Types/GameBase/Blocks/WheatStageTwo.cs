using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class WheatStageTwo : ColonyAPI.Classes.Type
    {
        public WheatStageTwo(string name) : base(name)
        {
            this.ParentType = "wheatstage";
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage2";
            this.AllowCreative = false;

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheatstage1",   1,  0.8f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("wheat",   1,  0.03f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("straw",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
