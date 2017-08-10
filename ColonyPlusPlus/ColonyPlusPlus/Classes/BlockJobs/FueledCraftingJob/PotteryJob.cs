using Pipliz.APIProvider.Jobs;
using NPC;

namespace ColonyPlusPlus.Classes.BlockJobs.FueledCraftingJob
{
    class PotteryJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public string jobtype = "pottery";

        public override string NPCTypeKey { get { return "cpp.potter"; } }

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
            def.printName = "Potter";
            def.maskColor1 = new UnityEngine.Color32(204, 133, 108, 255);
            def.type = NPCTypeID.GetNextID();
            return def;
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

        public override void OnRemovedNPC()
        {
            Managers.NPCManager.removeNPCData(this.usedNPC.ID);
            base.OnRemovedNPC();
        }
    }
}
