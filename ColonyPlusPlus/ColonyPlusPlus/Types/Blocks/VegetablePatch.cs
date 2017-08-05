using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Types.Blocks
{
    class VegetablePatch : Classes.Type
    {
        public VegetablePatch(string name) : base(name, true)
        {
            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("carrotstage1", 3, 0.5f),
                new Classes.ItemHelper.OnRemove("potatostage1", 2, 0.5f),
                new Classes.ItemHelper.OnRemove("lettucestage1", 2, 0.5f),
                new Classes.ItemHelper.OnRemove("onionstage1", 2, 0.5f)
            };

            this.OnRemove = onRemoveNode;

            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";
            this.IsBaseBlock = false;

            this.Register();
        }
    }
}
