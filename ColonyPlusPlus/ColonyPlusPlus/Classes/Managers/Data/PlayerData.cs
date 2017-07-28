using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Data
{
    class PlayerData
    {
        private NetworkID PID;
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
