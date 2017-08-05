using Pipliz.APIProvider.Jobs;
using NPC;

namespace ColonyPlusPlus.Classes.BlockJobs.FueledCraftingJob
{
    class PotteryJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
     {
        public override string NPCTypeKey { get { return "cpp.Potter"; } }

        public override float TimeBetweenJobs { get { return 2.9f; } }

        public override int MaxRecipeCraftsPerHaul { get { return 6; } }

        public NPCTypeSettings GetNPCTypeDefinition()
        {
            NPCTypeSettings def = NPCTypeSettings.Default;
            def.keyName = NPCTypeKey;
            def.printName = "Potter";
            def.maskColor1 = new UnityEngine.Color32(10, 10, 10, 255);
            def.type = NPCTypeID.GetNextID();
            return def;
        }
    }
}
