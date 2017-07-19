using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.types
{
    public class newdirt
    {

        public newdirt()
        {

        }

        public void run()
        {
            classes.Type nd = new classes.Type("nwedirt");

            nd.OnPlaceAudio = "dirtPlace";
            nd.OnRemoveAudio = "grassDelete";

            nd.Register();
        }

    }
}
