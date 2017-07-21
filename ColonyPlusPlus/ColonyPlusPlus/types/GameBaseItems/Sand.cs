using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.GameBaseItems
{
    class Sand : classes.Type
    {
        public Sand(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("sand",   1,  1.0f)
            };
            this.OnRemove = onRemoveNode;

            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.Register();
            
        }
    }
}
