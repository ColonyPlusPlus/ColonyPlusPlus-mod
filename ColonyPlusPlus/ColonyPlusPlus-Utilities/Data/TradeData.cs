namespace ColonyPlusPlusUtilities.Data
{
    class TradeData
    {

        public ushort giveId { get; private set; }
        public int giveAmount { get; private set; }
        private string giveName;
        public ushort takeId { get; private set; }
        public int takeAmount { get; private set; }
        private string takeName;
        public PlayerData partner { get; private set; }
        public bool wasitme { get; private set; }


        /// <summary>
        /// Creates a trade data.
        /// </summary>
        /// <param name="give">The id of the item the player will be given.</param>
        /// <param name="giveamt">The amount that is being given.</param>
        /// <param name="take">The id of the item the player is giving away.</param>
        /// <param name="takeamt">The amount that is being given away.</param>
        /// <param name="partner">The player we are trading with.</param>
        /// <param name="takeamt">Did we initiate the trade?</param>
        public TradeData(ushort give, int giveamt, ushort take, int takeamt, ref PlayerData partner, bool wasitme)
        {
            this.giveId = give;
            this.giveAmount = giveamt;
            this.takeId = take;
            this.takeAmount = takeamt;
            this.giveName = ItemTypes.IndexLookup.GetName(giveId);
            this.takeName = ItemTypes.IndexLookup.GetName(takeId);
            this.partner = partner;
            this.wasitme = wasitme;
        }

        override public string ToString()
        {
            return "your " + takeAmount + " " + takeName + " for " + giveAmount + " " + giveName;
        }

    }
}
