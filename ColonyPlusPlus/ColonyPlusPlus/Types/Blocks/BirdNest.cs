using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class BirdNest : ColonyAPI.Classes.Type
    {
        public BirdNest(string name) : base(name, true)
        {
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("feather", 3, 0.5f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("egg", 3, 0.5f)
            };
            this.AllowCreative = true;
            this.Register();
        }
    }
}
