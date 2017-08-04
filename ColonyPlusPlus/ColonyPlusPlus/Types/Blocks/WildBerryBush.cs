using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz;
using Pipliz.JSON;
using UpdatableBlocks;

namespace ColonyPlusPlus.Types.Blocks
{
    class WildBerryBush : Classes.Type
    {
        public WildBerryBush(string name) : base(name, true)
        {
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";

            Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new Classes.ItemHelper.OnRemove("berry",        1,  0.8f),
                new Classes.ItemHelper.OnRemove("berry",        2,  0.2f),
                new Classes.ItemHelper.OnRemove("berry",        5,  0.01f),
                new Classes.ItemHelper.OnRemove("berrybush",    1,  0.15f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
