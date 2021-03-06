﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz;
using Pipliz.JSON;
using UpdatableBlocks;

namespace ColonyPlusPlusCore.Types.Blocks
{
    class WildBerryBush : ColonyAPI.Classes.Type, ColonyAPI.Interfaces.IAutoType
    {
        public WildBerryBush() : base(true)
        {
            this.TypeName = "wildberrybush";
            this.OnPlaceAudio = "dirtPlace";
            this.OnRemoveAudio = "grassDelete";

            ColonyAPI.Classes.ItemHelper.OnRemove[] onRemoveNode = {
                new ColonyAPI.Classes.ItemHelper.OnRemove("berry",        1,  0.8f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("berry",        2,  0.2f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("berry",        5,  0.01f),
                new ColonyAPI.Classes.ItemHelper.OnRemove("berrybush",    1,  0.15f)
            };
            this.OnRemove = onRemoveNode;
            this.IsBaseBlock = false;

            
        }
    }
}
