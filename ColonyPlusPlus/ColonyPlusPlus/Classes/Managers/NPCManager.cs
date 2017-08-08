using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class NPCManager
    {

        private static Dictionary<int, Data.NPCData> NPCDataList = new Dictionary<int, Data.NPCData>();

        public static Data.NPCData getNPCData(int id)
        {
            if (NPCDataList.ContainsKey(id)) {
                return NPCDataList[id];
            } else
            {
                Data.NPCData d = new Data.NPCData();
                NPCDataList.Add(id, d);
                return d;
            }
        }

        public static void updateNPCData(int id, Data.NPCData d)
        {
            NPCDataList[id] = d;
        }

        public static void removeNPCData(int id)
        {
            if(NPCDataList.ContainsKey(id))
            {
                NPCDataList.Remove(id);
            }
        }

    }

}
