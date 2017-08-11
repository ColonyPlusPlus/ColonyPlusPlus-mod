using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz.JSON;

namespace ColonyPlusPlusUtilities.Managers
{
    public static class BanManager
    {
        private static Dictionary<ulong, Data.BanData> BanList;
        private static string savePath = "gamedata/savegames/cppbans.json";

        public static void initialise()
        {
            BanList = new Dictionary<ulong, Data.BanData>();
            loadBanList();
        }

        public static bool addBan(NetworkID id, string reason)
        {
            if(BanList.ContainsKey(id.steamID.m_SteamID)) {
                return false;
            } else
            {
                string bantime = Pipliz.Time.FullTimeStamp();
                Data.BanData bd = new Data.BanData(id,  reason, bantime);
                BanList.Add(id.steamID.m_SteamID, bd);
                SaveBanList();

                return true;
            }
           
        }

        public static bool removeBan(NetworkID id)
        {
            if(BanList.ContainsKey(id.steamID.m_SteamID))
            {
                BanList.Remove(id.steamID.m_SteamID);
                SaveBanList();
                return true;
            } else
            {
                return false;
            }
            
        }

        public static void loadBanList()
        {
            try
            {

                JSONNode array;
                if (Pipliz.JSON.JSON.Deserialize(savePath, out array, false))
                {

                    if (array != null)
                    {
                        foreach (JSONNode node in array.LoopArray())
                        {
                            try
                            {
                               ulong id = node["id"].GetAs<ulong>();
                                string reason = node["reason"].GetAs<string>();
                                string bantime = node["bantime"].GetAs<string>();

                                if (!BanList.ContainsKey(id))
                                {
                                    Data.BanData bd = new Data.BanData(new NetworkID(new Steamworks.CSteamID(id)), reason, bantime);
                                    BanList.Add(id, bd);
                                }



                            }
                            catch (Exception exception)
                            {
                                Utilities.WriteLog("Exception loading ban list;" + exception.Message);
                            }
                        }

                        Utilities.WriteLog("Loaded Ban List");
                    }
                    else
                    {
                        Utilities.WriteLog("Loading Ban list Returned 0 results");
                    }
                }
                else
                {
                    Utilities.WriteLog("Found no ban list (read error?)");
                }

            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Exception in loading all bans:" + exception2.Message);
            }

           
        }

        public static void SaveBanList()
        {
            try
            {
                JSONNode node = new JSONNode(NodeType.Array);

                foreach (Data.BanData bd in BanList.Values)
                {
                    JSONNode n = new JSONNode(NodeType.Object);
                    n.SetAs<ulong>("id", bd.getID().steamID.m_SteamID);
                    n.SetAs<string>("reason", bd.getReason());
                    n.SetAs<string>("bantime", bd.getTime());

                    node.AddToArray(n);
                }

                Pipliz.JSON.JSON.Serialize(savePath, node);
            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Exception in saving bans:" + exception2.Message);
            }
        }

    }
}
