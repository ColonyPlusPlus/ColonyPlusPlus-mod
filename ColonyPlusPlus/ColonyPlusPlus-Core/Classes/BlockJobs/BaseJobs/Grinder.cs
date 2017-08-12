using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPC;
using Pipliz.APIProvider.Jobs;

namespace ColonyPlusPlusCore.Classes.BlockJobs.BaseJobs
{
    public class Grinder : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public string jobtype = "grinding";

        public override string NPCTypeKey { get { return "pipliz.grinder"; } }

        public override float TimeBetweenJobs
        {
            get
            {
                Data.NPCData d = Managers.NPCManager.getNPCData(this.usedNPC.ID, this.owner);

                return 2.9f * d.XPData.getCraftingMultiplier(jobtype);
            }
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

        public override int MaxRecipeCraftsPerHaul { get { return 6; } }

        public override void OnRemovedNPC()
        {
            Managers.NPCManager.removeNPCData(this.usedNPC.ID);
            base.OnRemovedNPC();

        }
        NPCTypeSettings INPCTypeDefiner.GetNPCTypeDefinition()
        {
            NPCTypeSettings def = NPCTypeSettings.Default;
            def.keyName = NPCTypeKey;
            def.printName = "Grinder";
            def.maskColor1 = new UnityEngine.Color32(87, 66, 41, 255);
            def.type = NPCTypeID.GetNextID();
            return def;
        }
    }
}