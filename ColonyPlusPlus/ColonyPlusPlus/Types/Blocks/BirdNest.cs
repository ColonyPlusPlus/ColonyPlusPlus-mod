using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class BirdNest : Classes.Type
    {
        public BirdNest(string name) : base(name, true)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("feather", 3, 0.5f),
                new Classes.ItemHelper.OnRemove("egg", 3, 0.5f)
            };
            this.AllowCreative = true;
            this.Register();
        }
    }
}
