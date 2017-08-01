using Pipliz;

namespace ColonyPlusPlus.Classes.BlockJobs
{
    public interface IBlockJobBase
    {
        ITrackableBlock InitializeOnAdd(Vector3Int pos, ushort type, Players.Player player);
    }
}
