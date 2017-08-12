using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class BirdNest : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public BirdNest() : base(true)
        {
            this.TypeName = "birdnest";
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("feather", 3, 0.5f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("egg", 3, 0.5f)
            };
            this.AllowCreative = true;
            
        }
    }
}
