using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz;
using Pipliz.JSON;
using UpdatableBlocks;

namespace ColonyPlusPlus.types.blocks
{
    class WildBerryBush : classes.Type
    {
        public WildBerryBush(string name) : base(name)
        {
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";

            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("berry",        1,  0.8f),
                new classes.ItemHelper.OnRemove("berry",        2,  0.2f),
                new classes.ItemHelper.OnRemove("berry",        5,  0.01f),
                new classes.ItemHelper.OnRemove("berrybush",    1,  0.15f)
            };
            this.OnRemove = onRemoveNode;

            this.Register();
        }
    }
}
