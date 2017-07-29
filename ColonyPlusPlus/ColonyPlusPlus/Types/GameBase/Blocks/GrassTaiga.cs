using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class GrassTaiga : Classes.Type
    {
        public GrassTaiga(string name) : base(name)
        {
            this.ParentType = "grass";
            this.IsPlaceable = true;

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("grasstaiga",   1,  1.0f),
                new Classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f),
                new Classes.ItemHelper.OnRemove("sappling",     1,  0.03f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
