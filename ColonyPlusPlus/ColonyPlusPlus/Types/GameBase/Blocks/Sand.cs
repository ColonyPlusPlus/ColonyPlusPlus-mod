using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.GameBase.Blocks
{
    class Sand : ColonyAPI.Classes.Type
    {
        public Sand(string name) : base(name)
        {
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("sand", 1, 1f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("salt", 1, 0.2f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("salt", 1, 0.2f)
            };

            this.OnRemove = onRemoveNode;

            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "dirtPlace";
            this.IsPlaceable = true;
            this.Register();
            
        }
    }
}
