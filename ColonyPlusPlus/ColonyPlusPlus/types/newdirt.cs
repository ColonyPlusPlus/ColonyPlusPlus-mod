using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColonyPlusPlus.classes;

namespace ColonyPlusPlus.types
{
    public class newdirt
    {

        void run()
        {
            classes.Type nd = new classes.Type("nwedirt");

            nd.OnPlaceAudio = "dirtPlace";
            nd.OnRemoveAudio = "grassDelete";

            nd.Register();
        }

    }
}
