using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Sand : Classes.Type
    {
        public Sand(string name) : base(name)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("sand", 1, 1f),
                new Classes.ItemHelper.OnRemove("salt", 1, 0.2f),
                new Classes.ItemHelper.OnRemove("salt", 1, 0.2f)
            };

            this.OnRemove = onRemoveNode;

            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.IsPlaceable = true;
            this.Register();
            
        }
    }
}
