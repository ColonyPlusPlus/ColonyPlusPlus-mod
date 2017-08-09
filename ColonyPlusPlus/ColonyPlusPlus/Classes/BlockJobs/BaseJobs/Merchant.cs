using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPC;
using Pipliz.APIProvider.Jobs;

namespace ColonyPlusPlus.Classes.BlockJobs.BaseJobs
{
    public class Merchant : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public string jobtype = "trading";

        public override string NPCTypeKey { get { return "cpp.merchant"; } }

        public override float TimeBetweenJobs
        {
            get
            {
                Data.NPCData d = Managers.NPCManager.getNPCData(this.usedNPC.ID, this.owner);

                return 10f * d.XPData.getCraftingMultiplier(jobtype);
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

        NPCTypeSettings INPCTypeDefiner.GetNPCTypeDefinition()
        {
            NPCTypeSettings def = NPCTypeSettings.Default;
            def.keyName = NPCTypeKey;
            def.printName = "Merchant";
            def.maskColor1 = new UnityEngine.Color32(146, 31, 31, 255);
            def.type = NPCTypeID.GetNextID();
            def.inventoryCapacity = 1500f;
            return def;
        }
    }
}