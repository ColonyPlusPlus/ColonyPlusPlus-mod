﻿using Pipliz.APIProvider.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPC;

namespace ColonyPlusPlus.Classes.BlockJobs.CraftingJob
{
    class Blacksmith : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public override string NPCTypeKey { get { return "cpp.Blacksmith"; } }

        public override float TimeBetweenJobs { get { return 2.9f; } }

        public override int MaxRecipeCraftsPerHaul { get { return 6; } }

        public NPCTypeSettings GetNPCTypeDefinition()
        {
            NPCTypeSettings def = NPCTypeSettings.Default;
            def.keyName = NPCTypeKey;
            def.printName = "Blacksmith";
            def.maskColor1 = new UnityEngine.Color32(10, 10, 10, 255);
            def.type = NPCTypeID.GetNextID();
            return def;
        }
    }
}