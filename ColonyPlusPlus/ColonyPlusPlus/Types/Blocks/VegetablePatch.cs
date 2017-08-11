using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class VegetablePatch : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public VegetablePatch() : base(true)
        {
            this.TypeName = "vegetablepatch";
            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("carrotstage1", 3, 0.5f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("potatostage1", 2, 0.5f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("lettucestage1", 2, 0.5f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("onionstage1", 2, 0.5f)
            };

            this.OnRemove = onRemoveNode;

            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.IsBaseBlock = false;

            ) : base()
        }
    }
}
