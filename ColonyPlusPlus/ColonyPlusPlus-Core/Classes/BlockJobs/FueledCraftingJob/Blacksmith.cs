using Pipliz.APIProvider.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPC;

namespace ColonyPlusPlusCore.Classes.BlockJobs.CraftingJob
{
    class Blacksmith : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public string jobtype = "blacksmithing";

        public override string NPCTypeKey { get { return "cpp.blacksmith"; } }

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
            def.printName = "Blacksmith";
            def.maskColor1 = new UnityEngine.Color32(45, 75, 86, 255);
            def.type = NPCTypeID.GetNextID();
            return def;
        }

        public override void OnNPCDoJob(ref NPCBase.NPCState state)
        {
            base.OnNPCDoJob(ref state);

            if(state.IndicatorState.IndicatorType == NPCIndicatorType.Crafted)
            {

            }

            
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
