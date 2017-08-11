using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class BirdNest : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public BirdNest() : base(true)
        {
            this.TypeName = "birdnest";
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("feather", 3, 0.5f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("egg", 3, 0.5f)
            };
            this.AllowCreative = true;
            this.Register();
        }
    }
}
