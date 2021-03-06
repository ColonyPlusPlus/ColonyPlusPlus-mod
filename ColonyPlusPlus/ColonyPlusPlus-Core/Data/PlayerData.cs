﻿namespace ColonyPlusPlusCore.Data
{
    public class PlayerData
    {
        public NetworkID PID { get; private set; }
        public string chunkID;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Player NetworkID</param>
        /// <param name="cid">ChunkID</param>
        public PlayerData(NetworkID n, string cid)
        {
            PID = n;
            chunkID = cid;
        }
    }
}
