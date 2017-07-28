using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class WheatStageThree : Classes.Type
    {
        public WheatStageThree(string name) : base(name)
        {
            this.ParentType = "wheatstage";
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage3";
            this.AllowCreative = false;

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("wheatstage1",   1,  1.0f),
                new Classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f),
                new Classes.ItemHelper.OnRemove("wheat",   1,  1.0f),
                new Classes.ItemHelper.OnRemove("straw",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
