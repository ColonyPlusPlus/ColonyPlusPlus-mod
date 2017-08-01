using System.Collections.Generic;
using NPC;
using ColonyPlusPlus.Classes.Managers;

namespace ColonyPlusPlus.Classes.BlockJobs
{
    public class BlockJobManagerTracker
    {
        static List<IBlockJobManager> InstanceList = new List<IBlockJobManager>();

        public static void Register<T> (string blockName) where T : ITrackableBlock, IBlockJobBase, INPCTypeDefiner, new()
        {
            NPCType.AddSettings(new T().GetNPCTypeDefinition());
            InstanceList.Add(new BlockJobManager<T>(blockName));
        }

        public static void AfterWorldLoad()
        {
            for(int i = 0; i < InstanceList.Count; i++)
            {
                InstanceList[i].RegisterCallbackandLoad();
            }
        }

        public static void Save()
        {
            for(int i = 0; i < InstanceList.Count; i++)
            {
                InstanceList[i].OnSave();
            }
        }
    }
}
