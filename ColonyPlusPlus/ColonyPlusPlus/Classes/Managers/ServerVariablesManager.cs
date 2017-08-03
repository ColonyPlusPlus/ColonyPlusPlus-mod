using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz.JSON;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class ServerVariablesManager
    {
        private static JSONNode node = new Pipliz.JSON.JSONNode(Pipliz.JSON.NodeType.Object);

        public static void init()
        {
            if(Pipliz.JSON.JSON.Deserialize("gamedata/settings/server.json", out node, false)) {
                Utilities.WriteLog("Loaded server variables");
            }
        }

        public static string GetVariableAsString(string key)
        {
            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                if (node.HasChild(keys[0]))
                {
                    // has child
                    JSONNode c = new JSONNode(NodeType.Object);
                    c = node.GetAs<JSONNode>(keys[0]);
                    return c.GetAs<string>(keys[1]);

                }
                else
                {
                    return "";
                }
            }
            else
            {
                return node.GetAs<string>(key);
            }
        }

        public static int GetVariableAsInt(string key)
        {
            string[] keys = key.Split('.');


            if (keys.Length > 0)
            {
                if (node.HasChild(keys[0]))
                {
                    // has child
                    JSONNode c = new JSONNode(NodeType.Object);
                    c = node.GetAs<JSONNode>(keys[0]);
                    return c.GetAs<int>(keys[1]);

                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return node.GetAs<int>(key);
            }
        }

        public static float GetVariableAsFloat(string key)
        {
            string[] keys = key.Split('.');


            if (keys.Length > 0)
            {
                if (node.HasChild(keys[0]))
                {
                    // has child
                    JSONNode c = new JSONNode(NodeType.Object);
                    c = node.GetAs<JSONNode>(keys[0]);
                    return c.GetAs<float>(keys[1]);

                }
                else
                {
                    return 0F;
                }
            }
            else
            {
                return node.GetAs<float>(key);
            }
        }
    }
}
