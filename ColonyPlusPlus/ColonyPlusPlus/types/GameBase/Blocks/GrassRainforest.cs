using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class GrassRainforest : classes.Type
    {
        public GrassRainforest(string name) : base(name)
        {
            this.ParentType = "grass";
            this.IsPlaceable = true;

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("grassrainforest",   1,  1.0f),
                new classes.ItemHelper.OnRemove("wheatstage1",   1,  0.1f),
                new classes.ItemHelper.OnRemove("sappling",   1,  0.03f),
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
