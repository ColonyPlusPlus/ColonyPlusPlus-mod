using NPC;
using ColonyPlusPlus.Classes.BlockJobs;
using System;
using Pipliz;

namespace ColonyPlusPlus.Classes.Managers
{
    class BlockJobManager<T> : IBlockJobManager where T : IBlockJobBase, ITrackableBlock, new()
    {
        BlockTracker tracker;
        string blockName;
        public BlockJobManager (string blockName)
        {
            this.blockName = blockName;
            tracker = new BlockTracker(blockName);
        }

        public void OnSave()
        {
            tracker.Save();
        }

        public void RegisterCallbackandLoad()
        {
            ItemTypesServer.RegisterOnAdd(blockName, OnAdd);
            ItemTypesServer.RegisterOnRemove(blockName, OnRemove);
            tracker.Load<T>();
        }

        private void OnRemove(Vector3Int position, ushort type, Players.Player player)
        {
            tracker.Remove(position);
        }

        private void OnAdd(Vector3Int position, ushort type, Players.Player player)
        {
            tracker.Add(new T().InitializeOnAdd(position, type, player));
        }
    }
}
