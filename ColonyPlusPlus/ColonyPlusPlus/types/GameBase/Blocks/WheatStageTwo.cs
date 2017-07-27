using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class WheatStageTwo : Classes.Type
    {
        public WheatStageTwo(string name) : base(name)
        {
            this.ParentType = "wheatstage";
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage2";

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("wheatstage1",   1,  0.8f),
                new Classes.ItemHelper.OnRemove("wheat",   1,  0.03f),
                new Classes.ItemHelper.OnRemove("straw",   1,  0.1f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
