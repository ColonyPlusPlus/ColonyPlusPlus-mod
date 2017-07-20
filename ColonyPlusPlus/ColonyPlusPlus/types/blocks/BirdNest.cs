using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.types.blocks
{
    class BirdNest : classes.Type
    {
        public BirdNest(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("feather", 3, 0.5f),
                new classes.ItemHelper.OnRemove("egg", 3, 0.5f)
            };
            this.Register();
        }
    }
}
