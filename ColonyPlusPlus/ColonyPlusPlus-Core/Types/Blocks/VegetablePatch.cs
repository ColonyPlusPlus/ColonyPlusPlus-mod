using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class VegetablePatch : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public VegetablePatch() : base(true)
        {
            this.TypeName = "vegetablepatch";
            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("carrotstage1", 3, 0.5f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("potatostage1", 2, 0.5f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("lettucestage1", 2, 0.5f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("onionstage1", 2, 0.5f)
            };

            this.OnRemove = onRemoveNode;

            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.IsBaseBlock = false;

            
        }
    }
}
