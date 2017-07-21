using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Snow : classes.Type
    {
        public Snow(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("snow",         1,  1.0f)
            };
            this.OnRemove = onRemoveNode;
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.IsPlaceable = true;
            this.Register();
        }
    }
}
