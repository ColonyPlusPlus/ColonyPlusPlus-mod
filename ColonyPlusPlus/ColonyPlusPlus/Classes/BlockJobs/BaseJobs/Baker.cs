using BlockTypes.Builtin;
using System.Collections.Generic;
using NPC;
using Pipliz.APIProvider.Jobs;
using Pipliz;

namespace ColonyPlusPlus.Classes.BlockJobs.BaseJobs
{
    public class Baker : FueledCraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public string jobtype = "baking";

        public override string NPCTypeKey { get { return "cpp.baker"; } }

        public override float TimeBetweenJobs
        {
            get
            {
                Data.NPCData d = Managers.NPCManager.getNPCData(this.usedNPC.ID, this.owner);

                return 8.3f * d.XPData.getCraftingMultiplier(jobtype);
            }
        }

        public override int MaxRecipeCraftsPerHaul { get { return 3; } }

        public override void OnLit()
        {
            ushort litType;
            if (blockType == BuiltinBlocks.OvenUnlitXP)
            {
                litType = BuiltinBlocks.OvenLitXP;
            }
            else if (blockType == BuiltinBlocks.OvenUnlitXN)
            {
                litType = BuiltinBlocks.OvenLitXN;
            }
            else if (blockType == BuiltinBlocks.OvenUnlitZP)
            {
                litType = BuiltinBlocks.OvenLitZP;
            }
            else
            {
                litType = BuiltinBlocks.OvenLitZN;
            }
            ServerManager.TryChangeBlock(position, litType);
        }

        public override Vector3Int GetPositionNPC(Vector3Int position)
        {
            Vector3Int positionNPC;
            if (blockType == BuiltinBlocks.OvenUnlitXP || blockType == BuiltinBlocks.OvenLitXP)
            {
                positionNPC = position.Add(1, 0, 0);
            }
            else if (blockType == BuiltinBlocks.OvenUnlitXN || blockType == BuiltinBlocks.OvenLitXN)
            {
                positionNPC = position.Add(-1, 0, 0);
            }
            else if (blockType == BuiltinBlocks.OvenUnlitZP || blockType == BuiltinBlocks.OvenLitZP)
            {
                positionNPC = position.Add(0, 0, 1);
            }
            else if (blockType == BuiltinBlocks.OvenUnlitZN || blockType == BuiltinBlocks.OvenLitZN)
            {
                positionNPC = position.Add(0, 0, -1);
            }
            else
            {
                positionNPC = position;
            }
            return positionNPC;
        }

        NPCTypeSettings INPCTypeDefiner.GetNPCTypeDefinition()
        {
            NPCTypeSettings def = NPCTypeSettings.Default;
            def.keyName = NPCTypeKey;
            def.printName = "Baker";
            def.maskColor1 = new UnityEngine.Color32(192, 160, 117, 255);
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

        public override List<string> GetCraftingLimitsTriggers()
        {
            return new List<string>()
            {
                "ovenx+",
                "ovenx-",
                "ovenz+",
                "ovenz-",
                "ovenlitx+",
                "ovenlitx-",
                "ovenlitz+",
                "ovenlitz-"
            };
        }
    }
}