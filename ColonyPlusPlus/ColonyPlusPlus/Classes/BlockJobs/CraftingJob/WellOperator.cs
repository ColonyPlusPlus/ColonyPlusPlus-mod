using Pipliz.APIProvider.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPC;

namespace ColonyPlusPlus.Classes.BlockJobs.CraftingJob
{
    class WellOperator : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public string jobtype = "wellpumping";

        public override string NPCTypeKey { get { return "cpp.welloperator"; } }

        public override float TimeBetweenJobs
        {
            get
            {
                Data.NPCData d = Managers.NPCManager.getNPCData(this.usedNPC.ID, this.owner);

                return 2.9f * d.XPData.getCraftingMultiplier(jobtype);
            }
        }

        public override int MaxRecipeCraftsPerHaul { get { return 6; } }

        public NPCTypeSettings GetNPCTypeDefinition()
        {
            NPCTypeSettings def = NPCTypeSettings.Default;
            def.keyName = NPCTypeKey;
            def.printName = "Well operator";
            def.maskColor1 = new UnityEngine.Color32(9, 114, 155, 255);
            def.type = NPCTypeID.GetNextID();
            return def;
        }

        public override void OnNPCDoJob(ref NPCBase.NPCState state)
        {
            base.OnNPCDoJob(ref state);

            if (state.JobIsDone == true)
            {
                Data.NPCData d = Managers.NPCManager.getNPCData(this.usedNPC.ID, this.owner);
                d.XPData.addXP(this.usedNPC.ID, jobtype, this.owner);
                Managers.NPCManager.updateNPCData(this.usedNPC.ID, d);
            }
        }

        public override void OnRemovedNPC()
        {
            Managers.NPCManager.removeNPCData(this.usedNPC.ID);
            base.OnRemovedNPC();
        }
    }
}
