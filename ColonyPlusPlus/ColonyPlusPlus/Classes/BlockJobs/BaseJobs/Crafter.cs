using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPC;
using Pipliz.APIProvider.Jobs;

namespace ColonyPlusPlus.Classes.BlockJobs.BaseJobs
{
    public class Crafter : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public string jobtype = "crafting";

        public override string NPCTypeKey { get { return "cpp.crafter"; } }

        public override float TimeBetweenJobs
        {
            get
            {
                Data.NPCData d = Managers.NPCManager.getNPCData(this.usedNPC.ID, this.owner);

                return 5f * d.XPData.getCraftingMultiplier(jobtype);
            }
        }

        public override void OnNPCDoJob(ref NPCBase.NPCState state)
        {
            base.OnNPCDoJob(ref state);

            if (state.JobIsDone == true)
            {
                Data.NPCData d = Managers.NPCManager.getNPCData(this.usedNPC.ID, this.owner);
                d.XPData.addXP(jobtype, this.owner);
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
            def.printName = "Crafter";
            def.maskColor1 = new UnityEngine.Color32(81, 121, 123, 255);
            def.type = NPCTypeID.GetNextID();
            return def;
        }
    }
}