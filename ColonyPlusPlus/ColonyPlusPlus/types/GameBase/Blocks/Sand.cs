using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBase.Blocks
{
    class Sand : classes.Type
    {
        public Sand(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("sand", 1, 1f),
                new classes.ItemHelper.OnRemove("salt", 1, 0.2f),
                new classes.ItemHelper.OnRemove("salt", 1, 0.2f)
            };

            this.OnRemove = onRemoveNode;

            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.IsPlaceable = true;
            this.Register();
            
        }
    }
}
