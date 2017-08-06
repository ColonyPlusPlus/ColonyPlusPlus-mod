using NPC;
using Pipliz.APIProvider.Jobs;

namespace ColonyPlusPlus.Classes.BlockJobs.CraftingJob
{
    class ChickenPluckerJob : CraftingJobBase, IBlockJobBase, INPCTypeDefiner
    {
        public override string NPCTypeKey { get { return "cpp.chickenplucker"; } }

        public override float TimeBetweenJobs { get { return 2.9f; } }

        public override int MaxRecipeCraftsPerHaul { get { return 6; } }

        public NPCTypeSettings GetNPCTypeDefinition()
        {
            NPCTypeSettings def = NPCTypeSettings.Default;
            def.keyName = NPCTypeKey;
            def.printName = "ChickenPlucker";
            def.maskColor1 = new UnityEngine.Color32(10, 10, 10, 255);
            def.type = NPCTypeID.GetNextID();
            return def;
        }
    }
}
