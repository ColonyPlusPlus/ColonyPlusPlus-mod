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
            ItemTypesServer.RegisterOnAdd(blockName, onAdd);
            ItemTypesServer.RegisterOnAdd(blockName, onRemove);
        }

        private void onRemove(Vector3Int position, ushort type, Players.Player player)
        {
            tracker.Remove(position);
        }

        private void onAdd(Vector3Int position, ushort type, Players.Player player)
        {
            tracker.Add(new T().InitializeOnAdd(position, type, player));
        }
    }
}
