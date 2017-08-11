using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz;
using Pipliz.JSON;
using UpdatableBlocks;

namespace ColonyPlusPlus.Types.Blocks
{
    class WildBerryBush : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WildBerryBush() : base(true)
        {
            this.TypeName = "wildberrybush";
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";

            ColonyAPI.Helpers.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Helpers.ItemHelper.OnRemove("berry",        1,  0.8f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("berry",        2,  0.2f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("berry",        5,  0.01f),
                new ColonyAPI.Helpers.ItemHelper.OnRemove("berrybush",    1,  0.15f)
            };
            this.OnRemove = onRemoveNode;
            this.IsBaseBlock = false;

            ) : base()
        }
    }
}
