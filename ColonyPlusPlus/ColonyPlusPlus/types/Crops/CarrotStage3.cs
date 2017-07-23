﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes.Managers;

namespace ColonyPlusPlus.types.Crops
{
    class CarrotStage3 : classes.Type
    {
        public CarrotStage3(string name) : base(name)
        {
            classes.ItemHelper.OnRemove[] onRemoveNode = {
                new classes.ItemHelper.OnRemove("carrotstage1",   1,  1.0f),
                new classes.ItemHelper.OnRemove("carrotstage1",   2,  0.4f),
                new classes.ItemHelper.OnRemove("carrotstage1",   2,  0.4f),
                new classes.ItemHelper.OnRemove("carrotstage1",   2,  0.4f)
            };

            this.OnRemove = onRemoveNode;
            this.IsSolid = false;
            this.NeedsBase = true;
            this.IsPlaceable = true;
            this.OnRemoveAudio = "grassDelete";
            this.OnPlaceAudio = "grassDelete";
            this.MaxStackSize = 1200;
            this.NPCLimit = 0;
            this.SideAll = "wheatwheat";
            this.Mesh = "wheatstage3";
            this.IsPlaceable = true;

            this.Register();
        }
    }
}