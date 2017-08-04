using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pipliz.JSON;

namespace ColonyPlusPlus.Classes.Managers
{
    public static class ConfigManager
    {

        private static JSONNode configSettings;

        public static string getConfigString(string key) {
            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                return getConfigStringFromNode(keys, 0, configSettings);
            }
            else
            {
                return configSettings.GetAs<string>(key);
            }
        }

        private static string getConfigStringFromNode(string[] keys, int keyIndex, JSONNode node)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        // has child
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return getConfigStringFromNode(keys, keyIndex + 1, c);

                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return node.GetAs<string>(keys[keyIndex]);
                }
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration:" + exception.Message + exception.StackTrace);
                return "";
            }

        }

        public static bool getConfigBoolean(string key) {
            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                return getConfigBoolFromNode(keys, 0, configSettings);
            }
            else
            {
                return configSettings.GetAs<bool>(key);
            }
        }

        private static bool getConfigBoolFromNode(string[] keys, int keyIndex, JSONNode node)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        // has child
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return getConfigBoolFromNode(keys, keyIndex + 1, c);

                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return node.GetAs<bool>(keys[keyIndex]);
                }
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration:" + exception.Message + exception.StackTrace);
                return false;
            }

        }

        public static int getConfigInt(string key) {
            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                return getConfigIntFromNode(keys, 0, configSettings);
            }
            else
            {
                return configSettings.GetAs<int>(key);
            }
        }

        private static int getConfigIntFromNode(string[] keys, int keyIndex, JSONNode node)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        // has child
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return getConfigIntFromNode(keys, keyIndex + 1, c);

                    }
                    else
                    {
                        return -1;
                    }
                }
                else
                {
                    return node.GetAs<int>(keys[keyIndex]);
                }
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration:" + exception.Message + exception.StackTrace);
                return -1;
            }

        }  

        public static float getConfigFloat(string key) {
            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                return getConfigFloatFromNode(keys, 0, configSettings);
            }
            else
            {
                return configSettings.GetAs<float>(key);
            }
        }

        private static float getConfigFloatFromNode(string[] keys, int keyIndex, JSONNode node)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        // has child
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return getConfigFloatFromNode(keys, keyIndex + 1, c);

                    }
                    else
                    {
                        return 0f;
                    }
                }
                else
                {
                    return node.GetAs<float>(keys[keyIndex]);
                }
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration:" + exception.Message);
                return 0f;
            }

        }

        public static JSONNode getConfigNode(string key) {
            string[] keys = key.Split('.');

            if (keys.Length > 0)
            {
                return getConfigNodeFromNode(keys, 0, configSettings);
            }
            else
            {
                return configSettings.GetAs<JSONNode>(key);
            }
        }

        private static JSONNode getConfigNodeFromNode(string[] keys, int keyIndex, JSONNode node)
        {
            try
            {
                if (keys.Length > 0 && keyIndex < keys.Length)
                {
                    if (node.HasChild(keys[keyIndex]))
                    {
                        // has child
                        JSONNode c = new JSONNode(NodeType.Object);
                        c = node.GetAs<JSONNode>(keys[keyIndex]);
                        return getConfigNodeFromNode(keys, keyIndex + 1, c);

                    }
                    else
                    {
                        return new JSONNode(NodeType.Array);
                    }
                }
                else
                {
                    return node.GetAs<JSONNode>(keys[keyIndex]);
                }
            }
            catch (Exception exception)
            {
                Utilities.WriteLog("Error getting configuration:" + exception.Message + exception.StackTrace);
                return new JSONNode(NodeType.Array);
            }

        }

        

        /// <summary>
        /// Initialise the config manager
        /// </summary>
        public static void initialise()
        {
            try
            {
                Pipliz.JSON.JSON.Deserialize(getConfigLocation(), out configSettings, true);
            }
            catch (Exception exception2)
            {
                Utilities.WriteLog("Error loading configuration:" + exception2.Message + exception2.StackTrace);
            }
        }

        /// <summary>
        /// Get the config location
        /// </summary>
        /// <returns></returns>
        private static string getConfigLocation()
        {
            return "gamedata/mods/ColonyPlusPlus/config.json";
        }
    }
}
