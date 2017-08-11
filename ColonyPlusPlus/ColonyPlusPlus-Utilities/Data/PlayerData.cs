namespace ColonyPlusPlusUtilities.Data
{
    class PlayerData
    {
        public NetworkID PID { get; private set; }
        public string chunkID;
        public TradeData tradeData;

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
