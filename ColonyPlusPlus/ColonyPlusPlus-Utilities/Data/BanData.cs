using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Data
{
    class BanData
    {
        private NetworkID _ID;
        private string _reason;
        private string _bantime;

        public BanData(NetworkID id, string reason, string bantime)
        {
            this._bantime = bantime;
            this._ID = id;
            this._reason = reason;
        }

        public string getReason()
        {
            return this._reason;
        }

        public string getTime()
        {
            return this._bantime;
        }

        public NetworkID getID()
        {
            return this._ID;
        }
    }
}
