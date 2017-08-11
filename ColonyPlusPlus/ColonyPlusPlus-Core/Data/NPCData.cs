using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Data
{
    public class NPCData
    {
        public XPData XPData;
        public Players.Player owner;
        public string name;

        public NPCData(Players.Player o)
        {
            owner = o;
            name = Managers.NPCManager.getRandomName();
            XPData = new XPData();
        }
    }
}
